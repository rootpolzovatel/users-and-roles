namespace UsersAndRoles.Domain.Models;

public class Action
{
	public Guid Id { get; set; }
	public string Name { get; set; } = string.Empty;
	public string Description { get; set; } = string.Empty;
	public bool Readiness { get; set; } = false;
}
