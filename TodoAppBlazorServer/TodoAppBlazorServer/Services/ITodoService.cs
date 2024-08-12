namespace TodoAppBlazorServer.Services;

public interface ITodoService
{
	public void Add(todoItem item);

	public IEnumerable<todoItem> GetAll();

	public void Delete(todoItem item);
}
