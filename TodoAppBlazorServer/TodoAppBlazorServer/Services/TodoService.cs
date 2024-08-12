namespace TodoAppBlazorServer.Services
{
	public class TodoService : ITodoService
	{
		private readonly IList<todoItem> _todoItems;

		public TodoService()
		{
			_todoItems = new List<todoItem>() {
				new todoItem("Do some work"),
				new todoItem("Go to gym"),
				new todoItem("Go on the treadmill"),
				new todoItem("Do a project")
			};
		}

		public void Add(todoItem item)
		{
			_todoItems.Add(item);
		}

		public IEnumerable<todoItem> GetAll()
		{
			return _todoItems.ToList();
		}

		public void Delete(todoItem item)
		{
			_todoItems.Remove(item);
		}

	}
}
