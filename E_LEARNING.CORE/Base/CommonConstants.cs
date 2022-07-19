using System;
using System.Collections.Generic;
using System.Text;

namespace E_LEARNING.CORE.Base
{
    public static class ApplicationMessage
    {
        public const string ERR_MSG_REQUIRED_FIELD = "{0} là trường bắt buộc. Hãy nhập {0}.";
        public const string ERR_MSG_NOT_EXIST = "{0} không tồn tại. Vui lòng kiểm tra lại!";
        public const string ERR_MSG_EMAIL_VALID = "Email không hợp lệ!";
        public const string ERR_MSG_PHONE_VALID = "Số điện thoại không hợp lệ!";
        public const string ERR_MSG_UNIQUE = "{0} này đã được đăng ký. Vui lòng kiểm tra lại!";
        public const string ERR_MSG_EXIST = "{0} này đã tồn tại. Vui lòng kiểm tra lại!";
    }

    public static class ApplicationObjects
    {
        public const string PASS = "Mật khẩu";
        public const string STUDENT = "Học sinh";
        public const string CLASS = "Lớp học";
        public const string ADMIN = "Admin";
        public const string TEACHER = "Giáo viên";
        public const string USER_NAME = "Tên tài khoản";

    }
}
