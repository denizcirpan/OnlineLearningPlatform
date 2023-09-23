namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DatabaseUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CourseAssignments", "isDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.CourseAssignments", "isActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.CourseAssignments", "creationTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.CourseAssignments", "updatedTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Assignments", "isDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Assignments", "isActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Assignments", "creationTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Assignments", "updatedTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Courses", "isDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Courses", "isActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Courses", "creationTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Courses", "updatedTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.CourseEnrollments", "isDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.CourseEnrollments", "isActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.CourseEnrollments", "creationTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.CourseEnrollments", "updatedTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Users", "isDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Users", "isActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Users", "creationTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Users", "updatedTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.CourseResources", "isDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.CourseResources", "isActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.CourseResources", "creationTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.CourseResources", "updatedTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Resources", "isDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Resources", "isActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Resources", "creationTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Resources", "updatedTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Lessons", "isDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Lessons", "isActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Lessons", "creationTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Lessons", "updatedTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Questions", "isDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Questions", "isActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Questions", "creationTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Questions", "updatedTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.StudentCourseAssignments", "isDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.StudentCourseAssignments", "isActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.StudentCourseAssignments", "creationTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.StudentCourseAssignments", "updatedTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.StudentCourseAssignments", "updatedTime");
            DropColumn("dbo.StudentCourseAssignments", "creationTime");
            DropColumn("dbo.StudentCourseAssignments", "isActive");
            DropColumn("dbo.StudentCourseAssignments", "isDeleted");
            DropColumn("dbo.Questions", "updatedTime");
            DropColumn("dbo.Questions", "creationTime");
            DropColumn("dbo.Questions", "isActive");
            DropColumn("dbo.Questions", "isDeleted");
            DropColumn("dbo.Lessons", "updatedTime");
            DropColumn("dbo.Lessons", "creationTime");
            DropColumn("dbo.Lessons", "isActive");
            DropColumn("dbo.Lessons", "isDeleted");
            DropColumn("dbo.Resources", "updatedTime");
            DropColumn("dbo.Resources", "creationTime");
            DropColumn("dbo.Resources", "isActive");
            DropColumn("dbo.Resources", "isDeleted");
            DropColumn("dbo.CourseResources", "updatedTime");
            DropColumn("dbo.CourseResources", "creationTime");
            DropColumn("dbo.CourseResources", "isActive");
            DropColumn("dbo.CourseResources", "isDeleted");
            DropColumn("dbo.Users", "updatedTime");
            DropColumn("dbo.Users", "creationTime");
            DropColumn("dbo.Users", "isActive");
            DropColumn("dbo.Users", "isDeleted");
            DropColumn("dbo.CourseEnrollments", "updatedTime");
            DropColumn("dbo.CourseEnrollments", "creationTime");
            DropColumn("dbo.CourseEnrollments", "isActive");
            DropColumn("dbo.CourseEnrollments", "isDeleted");
            DropColumn("dbo.Courses", "updatedTime");
            DropColumn("dbo.Courses", "creationTime");
            DropColumn("dbo.Courses", "isActive");
            DropColumn("dbo.Courses", "isDeleted");
            DropColumn("dbo.Assignments", "updatedTime");
            DropColumn("dbo.Assignments", "creationTime");
            DropColumn("dbo.Assignments", "isActive");
            DropColumn("dbo.Assignments", "isDeleted");
            DropColumn("dbo.CourseAssignments", "updatedTime");
            DropColumn("dbo.CourseAssignments", "creationTime");
            DropColumn("dbo.CourseAssignments", "isActive");
            DropColumn("dbo.CourseAssignments", "isDeleted");
        }
    }
}
