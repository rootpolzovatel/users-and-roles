namespace UsersAndRoles.Domain.Models;

public class Role
{
	public int Id { get; private set; }
	public string Name { get; private set; } = string.Empty;
	public List<Action> Actions { get; private set; } = new List<Action>();
}
