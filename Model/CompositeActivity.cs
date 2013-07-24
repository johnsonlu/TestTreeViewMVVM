namespace TestTreeViewMVVM.Model
{
    using System.Collections.ObjectModel;

    public class CompositeActivity : Activity
    {
        private ObservableCollection<Activity> _children;

        public CompositeActivity(string name, string description)
            : base(name, description)
        {
            this._children = new ObservableCollection<Activity>();
        }
    }
}
