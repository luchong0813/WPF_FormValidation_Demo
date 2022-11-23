using Prism.Commands;
using Prism.Mvvm;

using System.Windows;

using WPF_FormValidation_Demo.Models;

namespace WPF_FormValidation_Demo.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        //作者博客：https://www.cnblogs.com/chonglu/

        private string _title = "表单验证Demo By:傲慢与偏见";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private StudentModel _studentInfo;
        public StudentModel StudentInfo
        {
            get { return _studentInfo; }
            set { SetProperty(ref _studentInfo, value); RaisePropertyChanged(); }
        }

        public DelegateCommand SubmitCommand { get; set; }

        public MainWindowViewModel()
        {
            StudentInfo = new StudentModel();
            SubmitCommand = new DelegateCommand(Submit);
            //StudentInfo.IsFormValid = true;
        }

        private void Submit()
        {
            if (!StudentInfo.IsValidated)
            {
                StudentInfo.IsFormValid = true;
                MessageBox.Show("新生注册失败，请检查录入的新生信息是否正确！");
                return;
            }
            MessageBox.Show("新生注册成功！");
        }
    }
}
