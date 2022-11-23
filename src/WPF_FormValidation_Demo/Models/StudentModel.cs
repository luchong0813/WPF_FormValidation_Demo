using System.ComponentModel.DataAnnotations;

namespace WPF_FormValidation_Demo.Models
{
    public class StudentModel : ValidateModelBase
    {
        private string _StudentName;
        /// <summary>
        /// 学生姓名
        /// </summary>
        [Required(ErrorMessage = "学生姓名不允许为空")]
        [MinLength(2,ErrorMessage = "学生姓名不能少于两个字符")]
        public string StudentName
        {
            get { return _StudentName; }
            set { _StudentName = value; RaisePropertyChanged(); }
        }


        private int _StudentAge;
        /// <summary>
        /// 学生年龄
        /// </summary>
        [Required(ErrorMessage = "学生年龄不允许为空")]
        [Range(3, 120, ErrorMessage = "学生年龄范围需在1-120岁之间")]
        public int StudentAge
        {
            get { return _StudentAge; }
            set { _StudentAge = value; RaisePropertyChanged(); }
        }


        private string _StudentEmail;
        /// <summary>
        /// 学生邮箱
        /// </summary>
        [EmailAddress(ErrorMessage = "邮箱地址不合法")]
        public string StudentEmail
        {
            get { return _StudentEmail; }
            set { _StudentEmail = value; RaisePropertyChanged(); }
        }


        private string _StudentPhoneNumber;
        /// <summary>
        /// 学生手机号
        /// </summary>
        [Required(ErrorMessage = "学生手机号不允许为空")]
        [RegularExpression(@"^1[3-9]\d{9}$", ErrorMessage = "手机号不正确")]
        public string StudentPhoneNumber
        {
            get { return _StudentPhoneNumber; }
            set { _StudentPhoneNumber = value; }
        }

    }
}
