
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2024.3.0001.1
EntitySpaces Driver  : PostgreSQL
Date Generated       : 18-08-2024 17:47:31
===============================================================================
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Linq;
using System.Data;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

using EntitySpaces.Core;
using EntitySpaces.Interfaces;
using EntitySpaces.DynamicQuery;



namespace BusinessObjects
{
	/// <summary>
	/// Encapsulates the 'employee' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(Employee))]	
	[XmlType("Employee")]
	public partial class Employee : esEmployee
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new Employee();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 empid)
		{
			var obj = new Employee();
			obj.Empid = empid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 empid, esSqlAccessType sqlAccessType)
		{
			var obj = new Employee();
			obj.Empid = empid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("EmployeeCollection")]
	public partial class EmployeeCollection : esEmployeeCollection, IEnumerable<Employee>
	{
		public Employee FindByPrimaryKey(System.Int32 empid)
		{
			return this.SingleOrDefault(e => e.Empid == empid);
		}

		
				
	}



	[Serializable]	
	public partial class EmployeeQuery : esEmployeeQuery
	{
		public EmployeeQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public EmployeeQuery(string joinAlias, out EmployeeQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "EmployeeQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(EmployeeQuery query)
		{
			return EmployeeQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator EmployeeQuery(string query)
		{
			return (EmployeeQuery)EmployeeQuery.SerializeHelper.FromXml(query, typeof(EmployeeQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esEmployee : esEntity
	{
		public esEmployee()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 empid)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(empid);
			else
				return LoadByPrimaryKeyStoredProcedure(empid);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 empid)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(empid);
			else
				return LoadByPrimaryKeyStoredProcedure(empid);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 empid)
		{
			EmployeeQuery query = new EmployeeQuery();
			query.Where(query.Empid == empid);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 empid)
		{
			esParameters parms = new esParameters();
			parms.Add("Empid", empid);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to employee.empid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Empid
		{
			get
			{
				return base.GetSystemInt32(EmployeeMetadata.ColumnNames.Empid);
			}
			
			set
			{
				if(base.SetSystemInt32(EmployeeMetadata.ColumnNames.Empid, value))
				{
					OnPropertyChanged(EmployeeMetadata.PropertyNames.Empid);
				}
			}
		}		
		
		/// <summary>
		/// Maps to employee.lastname
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Lastname
		{
			get
			{
				return base.GetSystemString(EmployeeMetadata.ColumnNames.Lastname);
			}
			
			set
			{
				if(base.SetSystemString(EmployeeMetadata.ColumnNames.Lastname, value))
				{
					OnPropertyChanged(EmployeeMetadata.PropertyNames.Lastname);
				}
			}
		}		
		
		/// <summary>
		/// Maps to employee.firstname
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Firstname
		{
			get
			{
				return base.GetSystemString(EmployeeMetadata.ColumnNames.Firstname);
			}
			
			set
			{
				if(base.SetSystemString(EmployeeMetadata.ColumnNames.Firstname, value))
				{
					OnPropertyChanged(EmployeeMetadata.PropertyNames.Firstname);
				}
			}
		}		
		
		/// <summary>
		/// Maps to employee.title
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Title
		{
			get
			{
				return base.GetSystemString(EmployeeMetadata.ColumnNames.Title);
			}
			
			set
			{
				if(base.SetSystemString(EmployeeMetadata.ColumnNames.Title, value))
				{
					OnPropertyChanged(EmployeeMetadata.PropertyNames.Title);
				}
			}
		}		
		
		/// <summary>
		/// Maps to employee.titleofcourtesy
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Titleofcourtesy
		{
			get
			{
				return base.GetSystemString(EmployeeMetadata.ColumnNames.Titleofcourtesy);
			}
			
			set
			{
				if(base.SetSystemString(EmployeeMetadata.ColumnNames.Titleofcourtesy, value))
				{
					OnPropertyChanged(EmployeeMetadata.PropertyNames.Titleofcourtesy);
				}
			}
		}		
		
		/// <summary>
		/// Maps to employee.birthdate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? Birthdate
		{
			get
			{
				return base.GetSystemDateTime(EmployeeMetadata.ColumnNames.Birthdate);
			}
			
			set
			{
				if(base.SetSystemDateTime(EmployeeMetadata.ColumnNames.Birthdate, value))
				{
					OnPropertyChanged(EmployeeMetadata.PropertyNames.Birthdate);
				}
			}
		}		
		
		/// <summary>
		/// Maps to employee.hiredate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? Hiredate
		{
			get
			{
				return base.GetSystemDateTime(EmployeeMetadata.ColumnNames.Hiredate);
			}
			
			set
			{
				if(base.SetSystemDateTime(EmployeeMetadata.ColumnNames.Hiredate, value))
				{
					OnPropertyChanged(EmployeeMetadata.PropertyNames.Hiredate);
				}
			}
		}		
		
		/// <summary>
		/// Maps to employee.address
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Address
		{
			get
			{
				return base.GetSystemString(EmployeeMetadata.ColumnNames.Address);
			}
			
			set
			{
				if(base.SetSystemString(EmployeeMetadata.ColumnNames.Address, value))
				{
					OnPropertyChanged(EmployeeMetadata.PropertyNames.Address);
				}
			}
		}		
		
		/// <summary>
		/// Maps to employee.city
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String City
		{
			get
			{
				return base.GetSystemString(EmployeeMetadata.ColumnNames.City);
			}
			
			set
			{
				if(base.SetSystemString(EmployeeMetadata.ColumnNames.City, value))
				{
					OnPropertyChanged(EmployeeMetadata.PropertyNames.City);
				}
			}
		}		
		
		/// <summary>
		/// Maps to employee.region
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Region
		{
			get
			{
				return base.GetSystemString(EmployeeMetadata.ColumnNames.Region);
			}
			
			set
			{
				if(base.SetSystemString(EmployeeMetadata.ColumnNames.Region, value))
				{
					OnPropertyChanged(EmployeeMetadata.PropertyNames.Region);
				}
			}
		}		
		
		/// <summary>
		/// Maps to employee.postalcode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Postalcode
		{
			get
			{
				return base.GetSystemString(EmployeeMetadata.ColumnNames.Postalcode);
			}
			
			set
			{
				if(base.SetSystemString(EmployeeMetadata.ColumnNames.Postalcode, value))
				{
					OnPropertyChanged(EmployeeMetadata.PropertyNames.Postalcode);
				}
			}
		}		
		
		/// <summary>
		/// Maps to employee.country
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Country
		{
			get
			{
				return base.GetSystemString(EmployeeMetadata.ColumnNames.Country);
			}
			
			set
			{
				if(base.SetSystemString(EmployeeMetadata.ColumnNames.Country, value))
				{
					OnPropertyChanged(EmployeeMetadata.PropertyNames.Country);
				}
			}
		}		
		
		/// <summary>
		/// Maps to employee.phone
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Phone
		{
			get
			{
				return base.GetSystemString(EmployeeMetadata.ColumnNames.Phone);
			}
			
			set
			{
				if(base.SetSystemString(EmployeeMetadata.ColumnNames.Phone, value))
				{
					OnPropertyChanged(EmployeeMetadata.PropertyNames.Phone);
				}
			}
		}		
		
		/// <summary>
		/// Maps to employee.extension
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Extension
		{
			get
			{
				return base.GetSystemString(EmployeeMetadata.ColumnNames.Extension);
			}
			
			set
			{
				if(base.SetSystemString(EmployeeMetadata.ColumnNames.Extension, value))
				{
					OnPropertyChanged(EmployeeMetadata.PropertyNames.Extension);
				}
			}
		}		
		
		/// <summary>
		/// Maps to employee.photo
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Byte[] Photo
		{
			get
			{
				return base.GetSystemByteArray(EmployeeMetadata.ColumnNames.Photo);
			}
			
			set
			{
				if(base.SetSystemByteArray(EmployeeMetadata.ColumnNames.Photo, value))
				{
					OnPropertyChanged(EmployeeMetadata.PropertyNames.Photo);
				}
			}
		}		
		
		/// <summary>
		/// Maps to employee.notes
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Notes
		{
			get
			{
				return base.GetSystemString(EmployeeMetadata.ColumnNames.Notes);
			}
			
			set
			{
				if(base.SetSystemString(EmployeeMetadata.ColumnNames.Notes, value))
				{
					OnPropertyChanged(EmployeeMetadata.PropertyNames.Notes);
				}
			}
		}		
		
		/// <summary>
		/// Maps to employee.mgrid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Mgrid
		{
			get
			{
				return base.GetSystemInt32(EmployeeMetadata.ColumnNames.Mgrid);
			}
			
			set
			{
				if(base.SetSystemInt32(EmployeeMetadata.ColumnNames.Mgrid, value))
				{
					OnPropertyChanged(EmployeeMetadata.PropertyNames.Mgrid);
				}
			}
		}		
		
		/// <summary>
		/// Maps to employee.photopath
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Photopath
		{
			get
			{
				return base.GetSystemString(EmployeeMetadata.ColumnNames.Photopath);
			}
			
			set
			{
				if(base.SetSystemString(EmployeeMetadata.ColumnNames.Photopath, value))
				{
					OnPropertyChanged(EmployeeMetadata.PropertyNames.Photopath);
				}
			}
		}		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return EmployeeMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public EmployeeQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new EmployeeQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(EmployeeQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(EmployeeQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private EmployeeQuery query;		
	}



	[Serializable]
	abstract public partial class esEmployeeCollection : esEntityCollection<Employee>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return EmployeeMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "EmployeeCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public EmployeeQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new EmployeeQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(EmployeeQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new EmployeeQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(EmployeeQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((EmployeeQuery)query);
		}

		#endregion
		
		private EmployeeQuery query;
	}



	[Serializable]
	abstract public partial class esEmployeeQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return EmployeeMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Empid": return this.Empid;
				case "Lastname": return this.Lastname;
				case "Firstname": return this.Firstname;
				case "Title": return this.Title;
				case "Titleofcourtesy": return this.Titleofcourtesy;
				case "Birthdate": return this.Birthdate;
				case "Hiredate": return this.Hiredate;
				case "Address": return this.Address;
				case "City": return this.City;
				case "Region": return this.Region;
				case "Postalcode": return this.Postalcode;
				case "Country": return this.Country;
				case "Phone": return this.Phone;
				case "Extension": return this.Extension;
				case "Photo": return this.Photo;
				case "Notes": return this.Notes;
				case "Mgrid": return this.Mgrid;
				case "Photopath": return this.Photopath;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Empid
		{
			get { return new esQueryItem(this, EmployeeMetadata.ColumnNames.Empid, esSystemType.Int32); }
		} 
		
		public esQueryItem Lastname
		{
			get { return new esQueryItem(this, EmployeeMetadata.ColumnNames.Lastname, esSystemType.String); }
		} 
		
		public esQueryItem Firstname
		{
			get { return new esQueryItem(this, EmployeeMetadata.ColumnNames.Firstname, esSystemType.String); }
		} 
		
		public esQueryItem Title
		{
			get { return new esQueryItem(this, EmployeeMetadata.ColumnNames.Title, esSystemType.String); }
		} 
		
		public esQueryItem Titleofcourtesy
		{
			get { return new esQueryItem(this, EmployeeMetadata.ColumnNames.Titleofcourtesy, esSystemType.String); }
		} 
		
		public esQueryItem Birthdate
		{
			get { return new esQueryItem(this, EmployeeMetadata.ColumnNames.Birthdate, esSystemType.DateTime); }
		} 
		
		public esQueryItem Hiredate
		{
			get { return new esQueryItem(this, EmployeeMetadata.ColumnNames.Hiredate, esSystemType.DateTime); }
		} 
		
		public esQueryItem Address
		{
			get { return new esQueryItem(this, EmployeeMetadata.ColumnNames.Address, esSystemType.String); }
		} 
		
		public esQueryItem City
		{
			get { return new esQueryItem(this, EmployeeMetadata.ColumnNames.City, esSystemType.String); }
		} 
		
		public esQueryItem Region
		{
			get { return new esQueryItem(this, EmployeeMetadata.ColumnNames.Region, esSystemType.String); }
		} 
		
		public esQueryItem Postalcode
		{
			get { return new esQueryItem(this, EmployeeMetadata.ColumnNames.Postalcode, esSystemType.String); }
		} 
		
		public esQueryItem Country
		{
			get { return new esQueryItem(this, EmployeeMetadata.ColumnNames.Country, esSystemType.String); }
		} 
		
		public esQueryItem Phone
		{
			get { return new esQueryItem(this, EmployeeMetadata.ColumnNames.Phone, esSystemType.String); }
		} 
		
		public esQueryItem Extension
		{
			get { return new esQueryItem(this, EmployeeMetadata.ColumnNames.Extension, esSystemType.String); }
		} 
		
		public esQueryItem Photo
		{
			get { return new esQueryItem(this, EmployeeMetadata.ColumnNames.Photo, esSystemType.ByteArray); }
		} 
		
		public esQueryItem Notes
		{
			get { return new esQueryItem(this, EmployeeMetadata.ColumnNames.Notes, esSystemType.String); }
		} 
		
		public esQueryItem Mgrid
		{
			get { return new esQueryItem(this, EmployeeMetadata.ColumnNames.Mgrid, esSystemType.Int32); }
		} 
		
		public esQueryItem Photopath
		{
			get { return new esQueryItem(this, EmployeeMetadata.ColumnNames.Photopath, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class Employee : esEmployee
	{

		
		
	}
	



	[Serializable]
	public partial class EmployeeMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected EmployeeMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(EmployeeMetadata.ColumnNames.Empid, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = EmployeeMetadata.PropertyNames.Empid;
			c.IsInPrimaryKey = true;
			c.NumericPrecision = 32;
			c.HasDefault = true;
			c.Default = @"nextval('employee_empid_seq'::regclass)";
			m_columns.Add(c);
				
			c = new esColumnMetadata(EmployeeMetadata.ColumnNames.Lastname, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = EmployeeMetadata.PropertyNames.Lastname;
			c.CharacterMaxLength = 20;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EmployeeMetadata.ColumnNames.Firstname, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = EmployeeMetadata.PropertyNames.Firstname;
			c.CharacterMaxLength = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EmployeeMetadata.ColumnNames.Title, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = EmployeeMetadata.PropertyNames.Title;
			c.CharacterMaxLength = 30;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EmployeeMetadata.ColumnNames.Titleofcourtesy, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = EmployeeMetadata.PropertyNames.Titleofcourtesy;
			c.CharacterMaxLength = 25;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EmployeeMetadata.ColumnNames.Birthdate, 5, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = EmployeeMetadata.PropertyNames.Birthdate;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EmployeeMetadata.ColumnNames.Hiredate, 6, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = EmployeeMetadata.PropertyNames.Hiredate;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EmployeeMetadata.ColumnNames.Address, 7, typeof(System.String), esSystemType.String);
			c.PropertyName = EmployeeMetadata.PropertyNames.Address;
			c.CharacterMaxLength = 60;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EmployeeMetadata.ColumnNames.City, 8, typeof(System.String), esSystemType.String);
			c.PropertyName = EmployeeMetadata.PropertyNames.City;
			c.CharacterMaxLength = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EmployeeMetadata.ColumnNames.Region, 9, typeof(System.String), esSystemType.String);
			c.PropertyName = EmployeeMetadata.PropertyNames.Region;
			c.CharacterMaxLength = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EmployeeMetadata.ColumnNames.Postalcode, 10, typeof(System.String), esSystemType.String);
			c.PropertyName = EmployeeMetadata.PropertyNames.Postalcode;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EmployeeMetadata.ColumnNames.Country, 11, typeof(System.String), esSystemType.String);
			c.PropertyName = EmployeeMetadata.PropertyNames.Country;
			c.CharacterMaxLength = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EmployeeMetadata.ColumnNames.Phone, 12, typeof(System.String), esSystemType.String);
			c.PropertyName = EmployeeMetadata.PropertyNames.Phone;
			c.CharacterMaxLength = 24;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EmployeeMetadata.ColumnNames.Extension, 13, typeof(System.String), esSystemType.String);
			c.PropertyName = EmployeeMetadata.PropertyNames.Extension;
			c.CharacterMaxLength = 4;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EmployeeMetadata.ColumnNames.Photo, 14, typeof(System.Byte[]), esSystemType.ByteArray);
			c.PropertyName = EmployeeMetadata.PropertyNames.Photo;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EmployeeMetadata.ColumnNames.Notes, 15, typeof(System.String), esSystemType.String);
			c.PropertyName = EmployeeMetadata.PropertyNames.Notes;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EmployeeMetadata.ColumnNames.Mgrid, 16, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = EmployeeMetadata.PropertyNames.Mgrid;
			c.NumericPrecision = 32;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EmployeeMetadata.ColumnNames.Photopath, 17, typeof(System.String), esSystemType.String);
			c.PropertyName = EmployeeMetadata.PropertyNames.Photopath;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public EmployeeMetadata Meta()
		{
			return meta;
		}	
		
		public Guid DataID
		{
			get { return base.m_dataID; }
		}	
		
		public bool MultiProviderMode
		{
			get { return false; }
		}		

		public esColumnMetadataCollection Columns
		{
			get	{ return base.m_columns; }
		}
		
		#region ColumnNames
		public class ColumnNames
		{ 
			 public const string Empid = "empid";
			 public const string Lastname = "lastname";
			 public const string Firstname = "firstname";
			 public const string Title = "title";
			 public const string Titleofcourtesy = "titleofcourtesy";
			 public const string Birthdate = "birthdate";
			 public const string Hiredate = "hiredate";
			 public const string Address = "address";
			 public const string City = "city";
			 public const string Region = "region";
			 public const string Postalcode = "postalcode";
			 public const string Country = "country";
			 public const string Phone = "phone";
			 public const string Extension = "extension";
			 public const string Photo = "photo";
			 public const string Notes = "notes";
			 public const string Mgrid = "mgrid";
			 public const string Photopath = "photopath";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Empid = "Empid";
			 public const string Lastname = "Lastname";
			 public const string Firstname = "Firstname";
			 public const string Title = "Title";
			 public const string Titleofcourtesy = "Titleofcourtesy";
			 public const string Birthdate = "Birthdate";
			 public const string Hiredate = "Hiredate";
			 public const string Address = "Address";
			 public const string City = "City";
			 public const string Region = "Region";
			 public const string Postalcode = "Postalcode";
			 public const string Country = "Country";
			 public const string Phone = "Phone";
			 public const string Extension = "Extension";
			 public const string Photo = "Photo";
			 public const string Notes = "Notes";
			 public const string Mgrid = "Mgrid";
			 public const string Photopath = "Photopath";
		}
		#endregion	

		public esProviderSpecificMetadata GetProviderMetadata(string mapName)
		{
			MapToMeta mapMethod = mapDelegates[mapName];

			if (mapMethod != null)
				return mapMethod(mapName);
			else
				return null;
		}
		
		#region MAP esDefault
		
		static private int RegisterDelegateesDefault()
		{
			// This is only executed once per the life of the application
			lock (typeof(EmployeeMetadata))
			{
				if(EmployeeMetadata.mapDelegates == null)
				{
					EmployeeMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (EmployeeMetadata.meta == null)
				{
					EmployeeMetadata.meta = new EmployeeMetadata();
				}
				
				MapToMeta mapMethod = new MapToMeta(meta.esDefault);
				mapDelegates.Add("esDefault", mapMethod);
				mapMethod("esDefault");
			}
			return 0;
		}			

		private esProviderSpecificMetadata esDefault(string mapName)
		{
			if(!m_providerMetadataMaps.ContainsKey(mapName))
			{
				esProviderSpecificMetadata meta = new esProviderSpecificMetadata();			


				meta.AddTypeMap("Empid", new esTypeMap("int4", "System.Int32"));
				meta.AddTypeMap("Lastname", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Firstname", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Title", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Titleofcourtesy", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Birthdate", new esTypeMap("timestamp", "System.DateTime"));
				meta.AddTypeMap("Hiredate", new esTypeMap("timestamp", "System.DateTime"));
				meta.AddTypeMap("Address", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("City", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Region", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Postalcode", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Country", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Phone", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Extension", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Photo", new esTypeMap("bytea", "System.Byte[]"));
				meta.AddTypeMap("Notes", new esTypeMap("text", "System.String"));
				meta.AddTypeMap("Mgrid", new esTypeMap("int4", "System.Int32"));
				meta.AddTypeMap("Photopath", new esTypeMap("varchar", "System.String"));			
				
				
				
				meta.Source = "employee";
				meta.Destination = "employee";
				
				meta.spInsert = "proc_employeeInsert";				
				meta.spUpdate = "proc_employeeUpdate";		
				meta.spDelete = "proc_employeeDelete";
				meta.spLoadAll = "proc_employeeLoadAll";
				meta.spLoadByPrimaryKey = "proc_employeeLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private EmployeeMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
