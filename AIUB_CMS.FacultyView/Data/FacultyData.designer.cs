﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AIUB_CMS.FacultyView.Data
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="AIUB-CMS Database")]
	public partial class FacultyDataDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTest_CourseTable(Test_CourseTable instance);
    partial void UpdateTest_CourseTable(Test_CourseTable instance);
    partial void DeleteTest_CourseTable(Test_CourseTable instance);
    partial void InsertTest_CourseAssignment(Test_CourseAssignment instance);
    partial void UpdateTest_CourseAssignment(Test_CourseAssignment instance);
    partial void DeleteTest_CourseAssignment(Test_CourseAssignment instance);
    partial void InsertTest_AttendanceTable(Test_AttendanceTable instance);
    partial void UpdateTest_AttendanceTable(Test_AttendanceTable instance);
    partial void DeleteTest_AttendanceTable(Test_AttendanceTable instance);
    #endregion
		
		public FacultyDataDataContext() : 
				base(global::AIUB_CMS.FacultyView.Properties.Settings.Default.AIUB_CMS_DatabaseConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public FacultyDataDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public FacultyDataDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public FacultyDataDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public FacultyDataDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Test_FacultyTable> Test_FacultyTables
		{
			get
			{
				return this.GetTable<Test_FacultyTable>();
			}
		}
		
		public System.Data.Linq.Table<Test_CourseTable> Test_CourseTables
		{
			get
			{
				return this.GetTable<Test_CourseTable>();
			}
		}
		
		public System.Data.Linq.Table<Test_CourseAssignment> Test_CourseAssignments
		{
			get
			{
				return this.GetTable<Test_CourseAssignment>();
			}
		}
		
		public System.Data.Linq.Table<Test_AttendanceTable> Test_AttendanceTables
		{
			get
			{
				return this.GetTable<Test_AttendanceTable>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Test_FacultyTable")]
	public partial class Test_FacultyTable
	{
		
		private string _Name;
		
		private string _ID;
		
		private string _Password;
		
		private string _Email;
		
		private System.Nullable<int> _BloodGroup;
		
		private string _PhoneNumber;
		
		private System.Nullable<int> _Department;
		
		private System.Nullable<System.DateTime> _DOB;
		
		private System.Nullable<int> _Gender;
		
		private string _FatherName;
		
		private string _MotherName;
		
		private System.Nullable<int> _Nationality;
		
		private string _ImageDirectory;
		
		public Test_FacultyTable()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this._Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="VarChar(50)")]
		public string ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(50)")]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this._Password = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this._Email = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BloodGroup", DbType="Int")]
		public System.Nullable<int> BloodGroup
		{
			get
			{
				return this._BloodGroup;
			}
			set
			{
				if ((this._BloodGroup != value))
				{
					this._BloodGroup = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhoneNumber", DbType="NVarChar(50)")]
		public string PhoneNumber
		{
			get
			{
				return this._PhoneNumber;
			}
			set
			{
				if ((this._PhoneNumber != value))
				{
					this._PhoneNumber = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Department", DbType="Int")]
		public System.Nullable<int> Department
		{
			get
			{
				return this._Department;
			}
			set
			{
				if ((this._Department != value))
				{
					this._Department = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DOB", DbType="Date")]
		public System.Nullable<System.DateTime> DOB
		{
			get
			{
				return this._DOB;
			}
			set
			{
				if ((this._DOB != value))
				{
					this._DOB = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="Int")]
		public System.Nullable<int> Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this._Gender = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FatherName", DbType="NVarChar(50)")]
		public string FatherName
		{
			get
			{
				return this._FatherName;
			}
			set
			{
				if ((this._FatherName != value))
				{
					this._FatherName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MotherName", DbType="NVarChar(50)")]
		public string MotherName
		{
			get
			{
				return this._MotherName;
			}
			set
			{
				if ((this._MotherName != value))
				{
					this._MotherName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nationality", DbType="Int")]
		public System.Nullable<int> Nationality
		{
			get
			{
				return this._Nationality;
			}
			set
			{
				if ((this._Nationality != value))
				{
					this._Nationality = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ImageDirectory", DbType="NVarChar(250)")]
		public string ImageDirectory
		{
			get
			{
				return this._ImageDirectory;
			}
			set
			{
				if ((this._ImageDirectory != value))
				{
					this._ImageDirectory = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Test_CourseTable")]
	public partial class Test_CourseTable : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Name;
		
		private System.Nullable<int> _Department;
		
		private System.Nullable<int> _Credits;
		
		private System.Nullable<int> _Section;
		
		private System.Nullable<int> _DaySlot;
		
		private System.Nullable<int> _StartTime;
		
		private System.Nullable<int> _EndTime;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnDepartmentChanging(System.Nullable<int> value);
    partial void OnDepartmentChanged();
    partial void OnCreditsChanging(System.Nullable<int> value);
    partial void OnCreditsChanged();
    partial void OnSectionChanging(System.Nullable<int> value);
    partial void OnSectionChanged();
    partial void OnDaySlotChanging(System.Nullable<int> value);
    partial void OnDaySlotChanged();
    partial void OnStartTimeChanging(System.Nullable<int> value);
    partial void OnStartTimeChanged();
    partial void OnEndTimeChanging(System.Nullable<int> value);
    partial void OnEndTimeChanged();
    #endregion
		
		public Test_CourseTable()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Department", DbType="Int")]
		public System.Nullable<int> Department
		{
			get
			{
				return this._Department;
			}
			set
			{
				if ((this._Department != value))
				{
					this.OnDepartmentChanging(value);
					this.SendPropertyChanging();
					this._Department = value;
					this.SendPropertyChanged("Department");
					this.OnDepartmentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Credits", DbType="Int")]
		public System.Nullable<int> Credits
		{
			get
			{
				return this._Credits;
			}
			set
			{
				if ((this._Credits != value))
				{
					this.OnCreditsChanging(value);
					this.SendPropertyChanging();
					this._Credits = value;
					this.SendPropertyChanged("Credits");
					this.OnCreditsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Section", DbType="Int")]
		public System.Nullable<int> Section
		{
			get
			{
				return this._Section;
			}
			set
			{
				if ((this._Section != value))
				{
					this.OnSectionChanging(value);
					this.SendPropertyChanging();
					this._Section = value;
					this.SendPropertyChanged("Section");
					this.OnSectionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DaySlot", DbType="Int")]
		public System.Nullable<int> DaySlot
		{
			get
			{
				return this._DaySlot;
			}
			set
			{
				if ((this._DaySlot != value))
				{
					this.OnDaySlotChanging(value);
					this.SendPropertyChanging();
					this._DaySlot = value;
					this.SendPropertyChanged("DaySlot");
					this.OnDaySlotChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StartTime", DbType="Int")]
		public System.Nullable<int> StartTime
		{
			get
			{
				return this._StartTime;
			}
			set
			{
				if ((this._StartTime != value))
				{
					this.OnStartTimeChanging(value);
					this.SendPropertyChanging();
					this._StartTime = value;
					this.SendPropertyChanged("StartTime");
					this.OnStartTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EndTime", DbType="Int")]
		public System.Nullable<int> EndTime
		{
			get
			{
				return this._EndTime;
			}
			set
			{
				if ((this._EndTime != value))
				{
					this.OnEndTimeChanging(value);
					this.SendPropertyChanging();
					this._EndTime = value;
					this.SendPropertyChanged("EndTime");
					this.OnEndTimeChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Test_CourseAssignment")]
	public partial class Test_CourseAssignment : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _FacultyID;
		
		private System.Nullable<int> _CourseID;
		
		private System.Nullable<int> _Assigned;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnFacultyIDChanging(string value);
    partial void OnFacultyIDChanged();
    partial void OnCourseIDChanging(System.Nullable<int> value);
    partial void OnCourseIDChanged();
    partial void OnAssignedChanging(System.Nullable<int> value);
    partial void OnAssignedChanged();
    #endregion
		
		public Test_CourseAssignment()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FacultyID", DbType="NVarChar(50)")]
		public string FacultyID
		{
			get
			{
				return this._FacultyID;
			}
			set
			{
				if ((this._FacultyID != value))
				{
					this.OnFacultyIDChanging(value);
					this.SendPropertyChanging();
					this._FacultyID = value;
					this.SendPropertyChanged("FacultyID");
					this.OnFacultyIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CourseID", DbType="Int")]
		public System.Nullable<int> CourseID
		{
			get
			{
				return this._CourseID;
			}
			set
			{
				if ((this._CourseID != value))
				{
					this.OnCourseIDChanging(value);
					this.SendPropertyChanging();
					this._CourseID = value;
					this.SendPropertyChanged("CourseID");
					this.OnCourseIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Assigned", DbType="Int")]
		public System.Nullable<int> Assigned
		{
			get
			{
				return this._Assigned;
			}
			set
			{
				if ((this._Assigned != value))
				{
					this.OnAssignedChanging(value);
					this.SendPropertyChanging();
					this._Assigned = value;
					this.SendPropertyChanged("Assigned");
					this.OnAssignedChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Test_AttendanceTable")]
	public partial class Test_AttendanceTable : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _StudentID;
		
		private string _StudentMAC;
		
		private string _Class1;
		
		private string _Class2;
		
		private string _Class3;
		
		private string _Class4;
		
		private string _Class5;
		
		private string _Class6;
		
		private string _Class7;
		
		private string _Class8;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnStudentIDChanging(string value);
    partial void OnStudentIDChanged();
    partial void OnStudentMACChanging(string value);
    partial void OnStudentMACChanged();
    partial void OnClass1Changing(string value);
    partial void OnClass1Changed();
    partial void OnClass2Changing(string value);
    partial void OnClass2Changed();
    partial void OnClass3Changing(string value);
    partial void OnClass3Changed();
    partial void OnClass4Changing(string value);
    partial void OnClass4Changed();
    partial void OnClass5Changing(string value);
    partial void OnClass5Changed();
    partial void OnClass6Changing(string value);
    partial void OnClass6Changed();
    partial void OnClass7Changing(string value);
    partial void OnClass7Changed();
    partial void OnClass8Changing(string value);
    partial void OnClass8Changed();
    #endregion
		
		public Test_AttendanceTable()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StudentID", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string StudentID
		{
			get
			{
				return this._StudentID;
			}
			set
			{
				if ((this._StudentID != value))
				{
					this.OnStudentIDChanging(value);
					this.SendPropertyChanging();
					this._StudentID = value;
					this.SendPropertyChanged("StudentID");
					this.OnStudentIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StudentMAC", DbType="NVarChar(50)")]
		public string StudentMAC
		{
			get
			{
				return this._StudentMAC;
			}
			set
			{
				if ((this._StudentMAC != value))
				{
					this.OnStudentMACChanging(value);
					this.SendPropertyChanging();
					this._StudentMAC = value;
					this.SendPropertyChanged("StudentMAC");
					this.OnStudentMACChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Class1", DbType="NVarChar(50)")]
		public string Class1
		{
			get
			{
				return this._Class1;
			}
			set
			{
				if ((this._Class1 != value))
				{
					this.OnClass1Changing(value);
					this.SendPropertyChanging();
					this._Class1 = value;
					this.SendPropertyChanged("Class1");
					this.OnClass1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Class2", DbType="NVarChar(50)")]
		public string Class2
		{
			get
			{
				return this._Class2;
			}
			set
			{
				if ((this._Class2 != value))
				{
					this.OnClass2Changing(value);
					this.SendPropertyChanging();
					this._Class2 = value;
					this.SendPropertyChanged("Class2");
					this.OnClass2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Class3", DbType="NVarChar(50)")]
		public string Class3
		{
			get
			{
				return this._Class3;
			}
			set
			{
				if ((this._Class3 != value))
				{
					this.OnClass3Changing(value);
					this.SendPropertyChanging();
					this._Class3 = value;
					this.SendPropertyChanged("Class3");
					this.OnClass3Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Class4", DbType="NVarChar(50)")]
		public string Class4
		{
			get
			{
				return this._Class4;
			}
			set
			{
				if ((this._Class4 != value))
				{
					this.OnClass4Changing(value);
					this.SendPropertyChanging();
					this._Class4 = value;
					this.SendPropertyChanged("Class4");
					this.OnClass4Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Class5", DbType="NVarChar(50)")]
		public string Class5
		{
			get
			{
				return this._Class5;
			}
			set
			{
				if ((this._Class5 != value))
				{
					this.OnClass5Changing(value);
					this.SendPropertyChanging();
					this._Class5 = value;
					this.SendPropertyChanged("Class5");
					this.OnClass5Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Class6", DbType="NVarChar(50)")]
		public string Class6
		{
			get
			{
				return this._Class6;
			}
			set
			{
				if ((this._Class6 != value))
				{
					this.OnClass6Changing(value);
					this.SendPropertyChanging();
					this._Class6 = value;
					this.SendPropertyChanged("Class6");
					this.OnClass6Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Class7", DbType="NVarChar(50)")]
		public string Class7
		{
			get
			{
				return this._Class7;
			}
			set
			{
				if ((this._Class7 != value))
				{
					this.OnClass7Changing(value);
					this.SendPropertyChanging();
					this._Class7 = value;
					this.SendPropertyChanged("Class7");
					this.OnClass7Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Class8", DbType="NChar(10)")]
		public string Class8
		{
			get
			{
				return this._Class8;
			}
			set
			{
				if ((this._Class8 != value))
				{
					this.OnClass8Changing(value);
					this.SendPropertyChanging();
					this._Class8 = value;
					this.SendPropertyChanged("Class8");
					this.OnClass8Changed();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
