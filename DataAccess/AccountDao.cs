using Microsoft.Data.SqlClient;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DataAccess
{
    public class AccountDao
    {
        public static Account Login(string username, string password)
        {
            var account = new Account();
            try
            {
                using (var context = new BirdCage777Context())
                {
                    // Lấy tài khoản từ cơ sở dữ liệu dựa trên tên đăng nhập
                    account = context.Accounts.SingleOrDefault(r => r.Email.Trim() == username);

                    // Kiểm tra xem tài khoản có tồn tại và mật khẩu có khớp không
                    if (account != null && account.Password.Trim() == password)
                    {
                        return account; // Trả về tài khoản nếu đăng nhập thành công
                    }
                }
            }
            catch (Exception e)
            {
                // Xử lý exception tại đây (ghi log, thông báo, v.v.)
                throw new Exception(e.Message);
            }

            return null; // Trả về null nếu đăng nhập không thành công
        }
        public static List<Account> LoadAllAccounts()
        {
            List<Account> accounts = new List<Account>();

            try
            {
                using (var context = new BirdCage777Context())
                {
                    // Retrieve all accounts from the database
                    accounts = context.Accounts.ToList();
                }
            }
            catch (Exception e)
            {
                // Handle exceptions (log, show error message, etc.)
                throw new Exception(e.Message);
            }

            return accounts;
        }

    }
}
