namespace TodoAppBlazorServer
{
    public class todoItem{
        public todoItem(string text){
            Text = text;
        }
        public string Text { get; set; }
        public bool TaskCompleted { get; set; }
    }

}
