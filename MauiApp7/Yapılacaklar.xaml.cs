using System.Collections.ObjectModel;
using System.Formats.Tar;

namespace MauiApp7;

public partial class Yapılacaklar : ContentPage
{
    public ObservableCollection<TaskItem> Tasks { get; set; }
    public Yapılacaklar()
    {
        InitializeComponent();
        Tasks = new ObservableCollection<TaskItem>();
        TaskListView.ItemsSource = Tasks;
    }
    private void OnAddTaskClicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(TaskEntry.Text))
        {
            Tasks.Add(new TaskItem { Name = TaskEntry.Text });
            TaskEntry.Text = string.Empty;
        }
    }


    private void OnDeleteTaskClicked(object sender, EventArgs e)
    {
        var button = (Button)sender;
        var task = (TaskItem)button.BindingContext;
        Tasks.Remove(task);
    }
    private async void OnEditTaskClicked(object sender, EventArgs e)
    {
        var button = (Button)sender;
        var task = (TaskItem)button.BindingContext;


        string newName = await DisplayPromptAsync("Düzenle", "Yeni görev adını girin:", initialValue: task.Name);

        if (!string.IsNullOrWhiteSpace(newName))
        {
            task.Name = newName;
        }
    }
}


public class TaskItem
{
    public string Name { get; set; }
    public bool IsDone { get; set; }
}