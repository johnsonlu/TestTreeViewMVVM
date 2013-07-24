namespace TestTreeViewMVVM.Model
{
    public abstract class Activity : ViewModelBase
    {
        private string _name;

        private string _description;

        protected Activity(string name, string description)
        {
            this._name = name;
            this._description = description;
        }

        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
                this.RaisePropertyChanged();
            }
        }

        public string Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
                this.RaisePropertyChanged();
            }
        }
    }
}
