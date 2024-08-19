
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2024.3.0001.1
EntitySpaces Driver  : PostgreSQL
Date Generated       : 18-08-2024 17:47:27
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
	/// Encapsulates the 'customer' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(Customer))]	
	[XmlType("Customer")]
	public partial class Customer : esCustomer
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new Customer();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 custid)
		{
			var obj = new Customer();
			obj.Custid = custid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 custid, esSqlAccessType sqlAccessType)
		{
			var obj = new Customer();
			obj.Custid = custid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("CustomerCollection")]
	public partial class CustomerCollection : esCustomerCollection, IEnumerable<Customer>
	{
		public Customer FindByPrimaryKey(System.Int32 custid)
		{
			return this.SingleOrDefault(e => e.Custid == custid);
		}

		
				
	}



	[Serializable]	
	public partial class CustomerQuery : esCustomerQuery
	{
		public CustomerQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public CustomerQuery(string joinAlias, out CustomerQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "CustomerQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(CustomerQuery query)
		{
			return CustomerQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator CustomerQuery(string query)
		{
			return (CustomerQuery)CustomerQuery.SerializeHelper.FromXml(query, typeof(CustomerQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esCustomer : esEntity
	{
		public esCustomer()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 custid)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(custid);
			else
				return LoadByPrimaryKeyStoredProcedure(custid);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 custid)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(custid);
			else
				return LoadByPrimaryKeyStoredProcedure(custid);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 custid)
		{
			CustomerQuery query = new CustomerQuery();
			query.Where(query.Custid == custid);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 custid)
		{
			esParameters parms = new esParameters();
			parms.Add("Custid", custid);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to customer.custid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Custid
		{
			get
			{
				return base.GetSystemInt32(CustomerMetadata.ColumnNames.Custid);
			}
			
			set
			{
				if(base.SetSystemInt32(CustomerMetadata.ColumnNames.Custid, value))
				{
					OnPropertyChanged(CustomerMetadata.PropertyNames.Custid);
				}
			}
		}		
		
		/// <summary>
		/// Maps to customer.companyname
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Companyname
		{
			get
			{
				return base.GetSystemString(CustomerMetadata.ColumnNames.Companyname);
			}
			
			set
			{
				if(base.SetSystemString(CustomerMetadata.ColumnNames.Companyname, value))
				{
					OnPropertyChanged(CustomerMetadata.PropertyNames.Companyname);
				}
			}
		}		
		
		/// <summary>
		/// Maps to customer.contactname
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Contactname
		{
			get
			{
				return base.GetSystemString(CustomerMetadata.ColumnNames.Contactname);
			}
			
			set
			{
				if(base.SetSystemString(CustomerMetadata.ColumnNames.Contactname, value))
				{
					OnPropertyChanged(CustomerMetadata.PropertyNames.Contactname);
				}
			}
		}		
		
		/// <summary>
		/// Maps to customer.contacttitle
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Contacttitle
		{
			get
			{
				return base.GetSystemString(CustomerMetadata.ColumnNames.Contacttitle);
			}
			
			set
			{
				if(base.SetSystemString(CustomerMetadata.ColumnNames.Contacttitle, value))
				{
					OnPropertyChanged(CustomerMetadata.PropertyNames.Contacttitle);
				}
			}
		}		
		
		/// <summary>
		/// Maps to customer.address
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Address
		{
			get
			{
				return base.GetSystemString(CustomerMetadata.ColumnNames.Address);
			}
			
			set
			{
				if(base.SetSystemString(CustomerMetadata.ColumnNames.Address, value))
				{
					OnPropertyChanged(CustomerMetadata.PropertyNames.Address);
				}
			}
		}		
		
		/// <summary>
		/// Maps to customer.city
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String City
		{
			get
			{
				return base.GetSystemString(CustomerMetadata.ColumnNames.City);
			}
			
			set
			{
				if(base.SetSystemString(CustomerMetadata.ColumnNames.City, value))
				{
					OnPropertyChanged(CustomerMetadata.PropertyNames.City);
				}
			}
		}		
		
		/// <summary>
		/// Maps to customer.region
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Region
		{
			get
			{
				return base.GetSystemString(CustomerMetadata.ColumnNames.Region);
			}
			
			set
			{
				if(base.SetSystemString(CustomerMetadata.ColumnNames.Region, value))
				{
					OnPropertyChanged(CustomerMetadata.PropertyNames.Region);
				}
			}
		}		
		
		/// <summary>
		/// Maps to customer.postalcode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Postalcode
		{
			get
			{
				return base.GetSystemString(CustomerMetadata.ColumnNames.Postalcode);
			}
			
			set
			{
				if(base.SetSystemString(CustomerMetadata.ColumnNames.Postalcode, value))
				{
					OnPropertyChanged(CustomerMetadata.PropertyNames.Postalcode);
				}
			}
		}		
		
		/// <summary>
		/// Maps to customer.country
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Country
		{
			get
			{
				return base.GetSystemString(CustomerMetadata.ColumnNames.Country);
			}
			
			set
			{
				if(base.SetSystemString(CustomerMetadata.ColumnNames.Country, value))
				{
					OnPropertyChanged(CustomerMetadata.PropertyNames.Country);
				}
			}
		}		
		
		/// <summary>
		/// Maps to customer.phone
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Phone
		{
			get
			{
				return base.GetSystemString(CustomerMetadata.ColumnNames.Phone);
			}
			
			set
			{
				if(base.SetSystemString(CustomerMetadata.ColumnNames.Phone, value))
				{
					OnPropertyChanged(CustomerMetadata.PropertyNames.Phone);
				}
			}
		}		
		
		/// <summary>
		/// Maps to customer.fax
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Fax
		{
			get
			{
				return base.GetSystemString(CustomerMetadata.ColumnNames.Fax);
			}
			
			set
			{
				if(base.SetSystemString(CustomerMetadata.ColumnNames.Fax, value))
				{
					OnPropertyChanged(CustomerMetadata.PropertyNames.Fax);
				}
			}
		}		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return CustomerMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public CustomerQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new CustomerQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(CustomerQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(CustomerQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private CustomerQuery query;		
	}



	[Serializable]
	abstract public partial class esCustomerCollection : esEntityCollection<Customer>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return CustomerMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "CustomerCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public CustomerQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new CustomerQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(CustomerQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new CustomerQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(CustomerQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((CustomerQuery)query);
		}

		#endregion
		
		private CustomerQuery query;
	}



	[Serializable]
	abstract public partial class esCustomerQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return CustomerMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Custid": return this.Custid;
				case "Companyname": return this.Companyname;
				case "Contactname": return this.Contactname;
				case "Contacttitle": return this.Contacttitle;
				case "Address": return this.Address;
				case "City": return this.City;
				case "Region": return this.Region;
				case "Postalcode": return this.Postalcode;
				case "Country": return this.Country;
				case "Phone": return this.Phone;
				case "Fax": return this.Fax;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Custid
		{
			get { return new esQueryItem(this, CustomerMetadata.ColumnNames.Custid, esSystemType.Int32); }
		} 
		
		public esQueryItem Companyname
		{
			get { return new esQueryItem(this, CustomerMetadata.ColumnNames.Companyname, esSystemType.String); }
		} 
		
		public esQueryItem Contactname
		{
			get { return new esQueryItem(this, CustomerMetadata.ColumnNames.Contactname, esSystemType.String); }
		} 
		
		public esQueryItem Contacttitle
		{
			get { return new esQueryItem(this, CustomerMetadata.ColumnNames.Contacttitle, esSystemType.String); }
		} 
		
		public esQueryItem Address
		{
			get { return new esQueryItem(this, CustomerMetadata.ColumnNames.Address, esSystemType.String); }
		} 
		
		public esQueryItem City
		{
			get { return new esQueryItem(this, CustomerMetadata.ColumnNames.City, esSystemType.String); }
		} 
		
		public esQueryItem Region
		{
			get { return new esQueryItem(this, CustomerMetadata.ColumnNames.Region, esSystemType.String); }
		} 
		
		public esQueryItem Postalcode
		{
			get { return new esQueryItem(this, CustomerMetadata.ColumnNames.Postalcode, esSystemType.String); }
		} 
		
		public esQueryItem Country
		{
			get { return new esQueryItem(this, CustomerMetadata.ColumnNames.Country, esSystemType.String); }
		} 
		
		public esQueryItem Phone
		{
			get { return new esQueryItem(this, CustomerMetadata.ColumnNames.Phone, esSystemType.String); }
		} 
		
		public esQueryItem Fax
		{
			get { return new esQueryItem(this, CustomerMetadata.ColumnNames.Fax, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class Customer : esCustomer
	{

		
		
	}
	



	[Serializable]
	public partial class CustomerMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected CustomerMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(CustomerMetadata.ColumnNames.Custid, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = CustomerMetadata.PropertyNames.Custid;
			c.IsInPrimaryKey = true;
			c.NumericPrecision = 32;
			c.HasDefault = true;
			c.Default = @"nextval('customer_custid_seq'::regclass)";
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomerMetadata.ColumnNames.Companyname, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomerMetadata.PropertyNames.Companyname;
			c.CharacterMaxLength = 40;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomerMetadata.ColumnNames.Contactname, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomerMetadata.PropertyNames.Contactname;
			c.CharacterMaxLength = 30;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomerMetadata.ColumnNames.Contacttitle, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomerMetadata.PropertyNames.Contacttitle;
			c.CharacterMaxLength = 30;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomerMetadata.ColumnNames.Address, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomerMetadata.PropertyNames.Address;
			c.CharacterMaxLength = 60;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomerMetadata.ColumnNames.City, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomerMetadata.PropertyNames.City;
			c.CharacterMaxLength = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomerMetadata.ColumnNames.Region, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomerMetadata.PropertyNames.Region;
			c.CharacterMaxLength = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomerMetadata.ColumnNames.Postalcode, 7, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomerMetadata.PropertyNames.Postalcode;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomerMetadata.ColumnNames.Country, 8, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomerMetadata.PropertyNames.Country;
			c.CharacterMaxLength = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomerMetadata.ColumnNames.Phone, 9, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomerMetadata.PropertyNames.Phone;
			c.CharacterMaxLength = 24;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomerMetadata.ColumnNames.Fax, 10, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomerMetadata.PropertyNames.Fax;
			c.CharacterMaxLength = 24;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public CustomerMetadata Meta()
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
			 public const string Custid = "custid";
			 public const string Companyname = "companyname";
			 public const string Contactname = "contactname";
			 public const string Contacttitle = "contacttitle";
			 public const string Address = "address";
			 public const string City = "city";
			 public const string Region = "region";
			 public const string Postalcode = "postalcode";
			 public const string Country = "country";
			 public const string Phone = "phone";
			 public const string Fax = "fax";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Custid = "Custid";
			 public const string Companyname = "Companyname";
			 public const string Contactname = "Contactname";
			 public const string Contacttitle = "Contacttitle";
			 public const string Address = "Address";
			 public const string City = "City";
			 public const string Region = "Region";
			 public const string Postalcode = "Postalcode";
			 public const string Country = "Country";
			 public const string Phone = "Phone";
			 public const string Fax = "Fax";
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
			lock (typeof(CustomerMetadata))
			{
				if(CustomerMetadata.mapDelegates == null)
				{
					CustomerMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (CustomerMetadata.meta == null)
				{
					CustomerMetadata.meta = new CustomerMetadata();
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


				meta.AddTypeMap("Custid", new esTypeMap("int4", "System.Int32"));
				meta.AddTypeMap("Companyname", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Contactname", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Contacttitle", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Address", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("City", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Region", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Postalcode", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Country", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Phone", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Fax", new esTypeMap("varchar", "System.String"));			
				
				
				
				meta.Source = "customer";
				meta.Destination = "customer";
				
				meta.spInsert = "proc_customerInsert";				
				meta.spUpdate = "proc_customerUpdate";		
				meta.spDelete = "proc_customerDelete";
				meta.spLoadAll = "proc_customerLoadAll";
				meta.spLoadByPrimaryKey = "proc_customerLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private CustomerMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
