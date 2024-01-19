using CitySays.Application.Absreactions;
using CitySays.Application.UseCases.Autors.Commands;
using CitySays.Domain.Entities;
using MediatR;

namespace CitySays.Application.UseCases.Autors.Handlers
{
    public class CreateAutorCommandHandler : IRequestHandler<CreateAutorCommand, bool>
    {
        private readonly IApplicationDbContext _applicationDbContext;

        public CreateAutorCommandHandler(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public async Task<bool> Handle(CreateAutorCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var newAutor = new Autor
                {
                    NickName = request.NickName
                };
                await _applicationDbContext.Autors.AddAsync(newAutor);
                await _applicationDbContext.SaveChangesAsync(cancellationToken);
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
