using DAL.Interfaces;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EF;
namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<User, String, User> UserDataAccess()
        {
            return new UserRepo();
        }

        public static IAuth AuthDataAccess()
        {
            return new UserRepo();
        }

        public static IToken<Token, String, Token> TokenDataAccess()
        {
            return new TokenRepo();
        }

        public static IRepo<Organization, int, Organization> OrgDataAccess()
        {
            return new OrganizationRepo();
        }


        public static IRepo<Role, int, Role> RoleDataAccess() 

        {
            return new RoleRepo();
        }

        public static IRepo<File, int, File> FileDataAccess()
        {
            return new FileRepos();
        }

        public static IRepo<Permission, int, Permission> PermissionDataAccess()
        {
            return new permissionRepo();
        }

        public static IRepo<Issue, int, Issue> IssueDataAccess() 
        {
            return new IssueRepos();
        }
    }
}
