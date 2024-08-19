
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2024.3.0001.1
EntitySpaces Driver  : PostgreSQL
Date Generated       : 18-08-2024 17:47:42
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
	/// Encapsulates the 'supplier' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(Supplier))]	
	[XmlType("Supplier")]
	public partial class Supplier : esSupplier
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new Supplier();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 supplierid)
		{
			var obj = new Supplier();
			obj.Supplierid = supplierid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 supplierid, esSqlAccessType sqlAccessType)
		{
			var obj = new Supplier();
			obj.Supplierid = supplierid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("SupplierCollection")]
	public partial class SupplierCollection : esSupplierCollection, IEnumerable<Supplier>
	{
		public Supplier FindByPrimaryKey(System.Int32 supplierid)
		{
			return this.SingleOrDefault(e => e.Supplierid == supplierid);
		}

		
				
	}



	[Serializable]	
	public partial class SupplierQuery : esSupplierQuery
	{
		public SupplierQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public SupplierQuery(string joinAlias, out SupplierQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "SupplierQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(SupplierQuery query)
		{
			return SupplierQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator SupplierQuery(string query)
		{
			return (SupplierQuery)SupplierQuery.SerializeHelper.FromXml(query, typeof(SupplierQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esSupplier : esEntity
	{
		public esSupplier()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 supplierid)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(supplierid);
			else
				return LoadByPrimaryKeyStoredProcedure(supplierid);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 supplierid)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(supplierid);
			else
				return LoadByPrimaryKeyStoredProcedure(supplierid);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 supplierid)
		{
			SupplierQuery query = new SupplierQuery();
			query.Where(query.Supplierid == supplierid);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 supplierid)
		{
			esParameters parms = new esParameters();
			parms.Add("Supplierid", supplierid);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to supplier.supplierid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Supplierid
		{
			get
			{
				return base.GetSystemInt32(SupplierMetadata.ColumnNames.Supplierid);
			}
			
			set
			{
				if(base.SetSystemInt32(SupplierMetadata.ColumnNames.Supplierid, value))
				{
					OnPropertyChanged(SupplierMetadata.PropertyNames.Supplierid);
				}
			}
		}		
		
		/// <summary>
		/// Maps to supplier.companyname
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Companyname
		{
			get
			{
				return base.GetSystemString(SupplierMetadata.ColumnNames.Companyname);
			}
			
			set
			{
				if(base.SetSystemString(SupplierMetadata.ColumnNames.Companyname, value))
				{
					OnPropertyChanged(SupplierMetadata.PropertyNames.Companyname);
				}
			}
		}		
		
		/// <summary>
		/// Maps to supplier.contactname
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Contactname
		{
			get
			{
				return base.GetSystemString(SupplierMetadata.ColumnNames.Contactname);
			}
			
			set
			{
				if(base.SetSystemString(SupplierMetadata.ColumnNames.Contactname, value))
				{
					OnPropertyChanged(SupplierMetadata.PropertyNames.Contactname);
				}
			}
		}		
		
		/// <summary>
		/// Maps to supplier.contacttitle
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Contacttitle
		{
			get
			{
				return base.GetSystemString(SupplierMetadata.ColumnNames.Contacttitle);
			}
			
			set
			{
				if(base.SetSystemString(SupplierMetadata.ColumnNames.Contacttitle, value))
				{
					OnPropertyChanged(SupplierMetadata.PropertyNames.Contacttitle);
				}
			}
		}		
		
		/// <summary>
		/// Maps to supplier.address
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Address
		{
			get
			{
				return base.GetSystemString(SupplierMetadata.ColumnNames.Address);
			}
			
			set
			{
				if(base.SetSystemString(SupplierMetadata.ColumnNames.Address, value))
				{
					OnPropertyChanged(SupplierMetadata.PropertyNames.Address);
				}
			}
		}		
		
		/// <summary>
		/// Maps to supplier.city
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String City
		{
			get
			{
				return base.GetSystemString(SupplierMetadata.ColumnNames.City);
			}
			
			set
			{
				if(base.SetSystemString(SupplierMetadata.ColumnNames.City, value))
				{
					OnPropertyChanged(SupplierMetadata.PropertyNames.City);
				}
			}
		}		
		
		/// <summary>
		/// Maps to supplier.region
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Region
		{
			get
			{
				return base.GetSystemString(SupplierMetadata.ColumnNames.Region);
			}
			
			set
			{
				if(base.SetSystemString(SupplierMetadata.ColumnNames.Region, value))
				{
					OnPropertyChanged(SupplierMetadata.PropertyNames.Region);
				}
			}
		}		
		
		/// <summary>
		/// Maps to supplier.postalcode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Postalcode
		{
			get
			{
				return base.GetSystemString(SupplierMetadata.ColumnNames.Postalcode);
			}
			
			set
			{
				if(base.SetSystemString(SupplierMetadata.ColumnNames.Postalcode, value))
				{
					OnPropertyChanged(SupplierMetadata.PropertyNames.Postalcode);
				}
			}
		}		
		
		/// <summary>
		/// Maps to supplier.country
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Country
		{
			get
			{
				return base.GetSystemString(SupplierMetadata.ColumnNames.Country);
			}
			
			set
			{
				if(base.SetSystemString(SupplierMetadata.ColumnNames.Country, value))
				{
					OnPropertyChanged(SupplierMetadata.PropertyNames.Country);
				}
			}
		}		
		
		/// <summary>
		/// Maps to supplier.phone
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Phone
		{
			get
			{
				return base.GetSystemString(SupplierMetadata.ColumnNames.Phone);
			}
			
			set
			{
				if(base.SetSystemString(SupplierMetadata.ColumnNames.Phone, value))
				{
					OnPropertyChanged(SupplierMetadata.PropertyNames.Phone);
				}
			}
		}		
		
		/// <summary>
		/// Maps to supplier.fax
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Fax
		{
			get
			{
				return base.GetSystemString(SupplierMetadata.ColumnNames.Fax);
			}
			
			set
			{
				if(base.SetSystemString(SupplierMetadata.ColumnNames.Fax, value))
				{
					OnPropertyChanged(SupplierMetadata.PropertyNames.Fax);
				}
			}
		}		
		
		/// <summary>
		/// Maps to supplier.homepage
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Homepage
		{
			get
			{
				return base.GetSystemString(SupplierMetadata.ColumnNames.Homepage);
			}
			
			set
			{
				if(base.SetSystemString(SupplierMetadata.ColumnNames.Homepage, value))
				{
					OnPropertyChanged(SupplierMetadata.PropertyNames.Homepage);
				}
			}
		}		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return SupplierMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public SupplierQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new SupplierQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(SupplierQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(SupplierQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private SupplierQuery query;		
	}



	[Serializable]
	abstract public partial class esSupplierCollection : esEntityCollection<Supplier>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return SupplierMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "SupplierCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public SupplierQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new SupplierQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(SupplierQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new SupplierQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(SupplierQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((SupplierQuery)query);
		}

		#endregion
		
		private SupplierQuery query;
	}



	[Serializable]
	abstract public partial class esSupplierQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return SupplierMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Supplierid": return this.Supplierid;
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
				case "Homepage": return this.Homepage;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Supplierid
		{
			get { return new esQueryItem(this, SupplierMetadata.ColumnNames.Supplierid, esSystemType.Int32); }
		} 
		
		public esQueryItem Companyname
		{
			get { return new esQueryItem(this, SupplierMetadata.ColumnNames.Companyname, esSystemType.String); }
		} 
		
		public esQueryItem Contactname
		{
			get { return new esQueryItem(this, SupplierMetadata.ColumnNames.Contactname, esSystemType.String); }
		} 
		
		public esQueryItem Contacttitle
		{
			get { return new esQueryItem(this, SupplierMetadata.ColumnNames.Contacttitle, esSystemType.String); }
		} 
		
		public esQueryItem Address
		{
			get { return new esQueryItem(this, SupplierMetadata.ColumnNames.Address, esSystemType.String); }
		} 
		
		public esQueryItem City
		{
			get { return new esQueryItem(this, SupplierMetadata.ColumnNames.City, esSystemType.String); }
		} 
		
		public esQueryItem Region
		{
			get { return new esQueryItem(this, SupplierMetadata.ColumnNames.Region, esSystemType.String); }
		} 
		
		public esQueryItem Postalcode
		{
			get { return new esQueryItem(this, SupplierMetadata.ColumnNames.Postalcode, esSystemType.String); }
		} 
		
		public esQueryItem Country
		{
			get { return new esQueryItem(this, SupplierMetadata.ColumnNames.Country, esSystemType.String); }
		} 
		
		public esQueryItem Phone
		{
			get { return new esQueryItem(this, SupplierMetadata.ColumnNames.Phone, esSystemType.String); }
		} 
		
		public esQueryItem Fax
		{
			get { return new esQueryItem(this, SupplierMetadata.ColumnNames.Fax, esSystemType.String); }
		} 
		
		public esQueryItem Homepage
		{
			get { return new esQueryItem(this, SupplierMetadata.ColumnNames.Homepage, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class Supplier : esSupplier
	{

		
		
	}
	



	[Serializable]
	public partial class SupplierMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected SupplierMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(SupplierMetadata.ColumnNames.Supplierid, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = SupplierMetadata.PropertyNames.Supplierid;
			c.IsInPrimaryKey = true;
			c.NumericPrecision = 32;
			c.HasDefault = true;
			c.Default = @"nextval('supplier_supplierid_seq'::regclass)";
			m_columns.Add(c);
				
			c = new esColumnMetadata(SupplierMetadata.ColumnNames.Companyname, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = SupplierMetadata.PropertyNames.Companyname;
			c.CharacterMaxLength = 40;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SupplierMetadata.ColumnNames.Contactname, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = SupplierMetadata.PropertyNames.Contactname;
			c.CharacterMaxLength = 30;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SupplierMetadata.ColumnNames.Contacttitle, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = SupplierMetadata.PropertyNames.Contacttitle;
			c.CharacterMaxLength = 30;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SupplierMetadata.ColumnNames.Address, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = SupplierMetadata.PropertyNames.Address;
			c.CharacterMaxLength = 60;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SupplierMetadata.ColumnNames.City, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = SupplierMetadata.PropertyNames.City;
			c.CharacterMaxLength = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SupplierMetadata.ColumnNames.Region, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = SupplierMetadata.PropertyNames.Region;
			c.CharacterMaxLength = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SupplierMetadata.ColumnNames.Postalcode, 7, typeof(System.String), esSystemType.String);
			c.PropertyName = SupplierMetadata.PropertyNames.Postalcode;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SupplierMetadata.ColumnNames.Country, 8, typeof(System.String), esSystemType.String);
			c.PropertyName = SupplierMetadata.PropertyNames.Country;
			c.CharacterMaxLength = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SupplierMetadata.ColumnNames.Phone, 9, typeof(System.String), esSystemType.String);
			c.PropertyName = SupplierMetadata.PropertyNames.Phone;
			c.CharacterMaxLength = 24;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SupplierMetadata.ColumnNames.Fax, 10, typeof(System.String), esSystemType.String);
			c.PropertyName = SupplierMetadata.PropertyNames.Fax;
			c.CharacterMaxLength = 24;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SupplierMetadata.ColumnNames.Homepage, 11, typeof(System.String), esSystemType.String);
			c.PropertyName = SupplierMetadata.PropertyNames.Homepage;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public SupplierMetadata Meta()
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
			 public const string Supplierid = "supplierid";
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
			 public const string Homepage = "homepage";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Supplierid = "Supplierid";
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
			 public const string Homepage = "Homepage";
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
			lock (typeof(SupplierMetadata))
			{
				if(SupplierMetadata.mapDelegates == null)
				{
					SupplierMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (SupplierMetadata.meta == null)
				{
					SupplierMetadata.meta = new SupplierMetadata();
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


				meta.AddTypeMap("Supplierid", new esTypeMap("int4", "System.Int32"));
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
				meta.AddTypeMap("Homepage", new esTypeMap("text", "System.String"));			
				
				
				
				meta.Source = "supplier";
				meta.Destination = "supplier";
				
				meta.spInsert = "proc_supplierInsert";				
				meta.spUpdate = "proc_supplierUpdate";		
				meta.spDelete = "proc_supplierDelete";
				meta.spLoadAll = "proc_supplierLoadAll";
				meta.spLoadByPrimaryKey = "proc_supplierLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private SupplierMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
