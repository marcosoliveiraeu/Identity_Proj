namespace MvcWebIdentity.Services
{
    public interface ISeedUserRoleInicial
    {

        Task SeedRolesAsync();
        Task SeedUserAsync();

    }
}
