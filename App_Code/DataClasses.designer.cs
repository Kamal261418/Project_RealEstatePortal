#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Teba")]
public partial class DataClassesDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void InsertProject(Project instance);
  partial void UpdateProject(Project instance);
  partial void DeleteProject(Project instance);
  #endregion
	
	public DataClassesDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["TebaConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<Project> Projects
	{
		get
		{
			return this.GetTable<Project>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Projects")]
public partial class Project : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ProjectId;
	
	private System.Data.Linq.Binary _ProjectImage;
	
	private string _ProjectName;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnProjectIdChanging(int value);
    partial void OnProjectIdChanged();
    partial void OnProjectImageChanging(System.Data.Linq.Binary value);
    partial void OnProjectImageChanged();
    partial void OnProjectNameChanging(string value);
    partial void OnProjectNameChanged();
    #endregion
	
	public Project()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProjectId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int ProjectId
	{
		get
		{
			return this._ProjectId;
		}
		set
		{
			if ((this._ProjectId != value))
			{
				this.OnProjectIdChanging(value);
				this.SendPropertyChanging();
				this._ProjectId = value;
				this.SendPropertyChanged("ProjectId");
				this.OnProjectIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProjectImage", DbType="Image", CanBeNull=true, UpdateCheck=UpdateCheck.Never)]
	public System.Data.Linq.Binary ProjectImage
	{
		get
		{
			return this._ProjectImage;
		}
		set
		{
			if ((this._ProjectImage != value))
			{
				this.OnProjectImageChanging(value);
				this.SendPropertyChanging();
				this._ProjectImage = value;
				this.SendPropertyChanged("ProjectImage");
				this.OnProjectImageChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProjectName", DbType="NVarChar(MAX)")]
	public string ProjectName
	{
		get
		{
			return this._ProjectName;
		}
		set
		{
			if ((this._ProjectName != value))
			{
				this.OnProjectNameChanging(value);
				this.SendPropertyChanging();
				this._ProjectName = value;
				this.SendPropertyChanged("ProjectName");
				this.OnProjectNameChanged();
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
#pragma warning restore 1591
