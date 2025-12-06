using AutoMapper;
using Library.Application.Mediator.Commands.AuthorCommands;
using Library.Application.Mediator.Results.AuthorResults.CommandResults;
using Library.Contract.RepositoryInterfaces;
using Library.Domain.Entities;
using MediatR;

namespace Library.Application.Mediator.Handlers.Modify.AuthorHandlers
{
    public class UpdateAuthorCommandHandler : IRequestHandler<UpdateAuthorCommand, GetAuthorCommandResult>
    {
        private readonly IAuthorRepository _repository;
        private readonly IMapper _mapper;

        public UpdateAuthorCommandHandler(IAuthorRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetAuthorCommandResult> Handle(UpdateAuthorCommand request, CancellationToken cancellationToken)
        {
            Author author = await _repository.GetByIdAsync(request.Id);

            if (author == null)
                return null;

            //requesten gelen değerlere author nesnesine aktarılır.
            _mapper.Map(request, author);

            author.UpdatedDate = DateTime.Now;
            author.Status = Domain.Enums.DataStatus.Updated;
            await _repository.SaveChangesAsync();

            return _mapper.Map<GetAuthorCommandResult>(author);
        }
    }
}
