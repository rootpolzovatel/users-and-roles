namespace UsersAndRoles.Domain.Models;

public class User
{
	public Guid Id { get; private set; }

	public string UserName { get; private set; } = string.Empty;
	public string PasswordHach { get; private set; } = string.Empty;
	public string Email { get; private set; } = string.Empty;

	public string Name { get; private set; } = string.Empty;
	public string LastName { get; private set; } = string.Empty;
	public string Patronymic { get; private set; } = string.Empty;

	public Role Role { get; private set; } 
}
