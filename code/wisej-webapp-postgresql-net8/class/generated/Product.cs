
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2024.3.0001.1
EntitySpaces Driver  : PostgreSQL
Date Generated       : 18-08-2024 17:47:36
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
	/// Encapsulates the 'product' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(Product))]	
	[XmlType("Product")]
	public partial class Product : esProduct
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new Product();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 productid)
		{
			var obj = new Product();
			obj.Productid = productid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 productid, esSqlAccessType sqlAccessType)
		{
			var obj = new Product();
			obj.Productid = productid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("ProductCollection")]
	public partial class ProductCollection : esProductCollection, IEnumerable<Product>
	{
		public Product FindByPrimaryKey(System.Int32 productid)
		{
			return this.SingleOrDefault(e => e.Productid == productid);
		}

		
				
	}



	[Serializable]	
	public partial class ProductQuery : esProductQuery
	{
		public ProductQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public ProductQuery(string joinAlias, out ProductQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "ProductQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(ProductQuery query)
		{
			return ProductQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator ProductQuery(string query)
		{
			return (ProductQuery)ProductQuery.SerializeHelper.FromXml(query, typeof(ProductQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esProduct : esEntity
	{
		public esProduct()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 productid)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(productid);
			else
				return LoadByPrimaryKeyStoredProcedure(productid);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 productid)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(productid);
			else
				return LoadByPrimaryKeyStoredProcedure(productid);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 productid)
		{
			ProductQuery query = new ProductQuery();
			query.Where(query.Productid == productid);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 productid)
		{
			esParameters parms = new esParameters();
			parms.Add("Productid", productid);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to product.productid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Productid
		{
			get
			{
				return base.GetSystemInt32(ProductMetadata.ColumnNames.Productid);
			}
			
			set
			{
				if(base.SetSystemInt32(ProductMetadata.ColumnNames.Productid, value))
				{
					OnPropertyChanged(ProductMetadata.PropertyNames.Productid);
				}
			}
		}		
		
		/// <summary>
		/// Maps to product.productname
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Productname
		{
			get
			{
				return base.GetSystemString(ProductMetadata.ColumnNames.Productname);
			}
			
			set
			{
				if(base.SetSystemString(ProductMetadata.ColumnNames.Productname, value))
				{
					OnPropertyChanged(ProductMetadata.PropertyNames.Productname);
				}
			}
		}		
		
		/// <summary>
		/// Maps to product.supplierid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Supplierid
		{
			get
			{
				return base.GetSystemInt32(ProductMetadata.ColumnNames.Supplierid);
			}
			
			set
			{
				if(base.SetSystemInt32(ProductMetadata.ColumnNames.Supplierid, value))
				{
					OnPropertyChanged(ProductMetadata.PropertyNames.Supplierid);
				}
			}
		}		
		
		/// <summary>
		/// Maps to product.categoryid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Categoryid
		{
			get
			{
				return base.GetSystemInt32(ProductMetadata.ColumnNames.Categoryid);
			}
			
			set
			{
				if(base.SetSystemInt32(ProductMetadata.ColumnNames.Categoryid, value))
				{
					OnPropertyChanged(ProductMetadata.PropertyNames.Categoryid);
				}
			}
		}		
		
		/// <summary>
		/// Maps to product.quantityperunit
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Quantityperunit
		{
			get
			{
				return base.GetSystemString(ProductMetadata.ColumnNames.Quantityperunit);
			}
			
			set
			{
				if(base.SetSystemString(ProductMetadata.ColumnNames.Quantityperunit, value))
				{
					OnPropertyChanged(ProductMetadata.PropertyNames.Quantityperunit);
				}
			}
		}		
		
		/// <summary>
		/// Maps to product.unitprice
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? Unitprice
		{
			get
			{
				return base.GetSystemDecimal(ProductMetadata.ColumnNames.Unitprice);
			}
			
			set
			{
				if(base.SetSystemDecimal(ProductMetadata.ColumnNames.Unitprice, value))
				{
					OnPropertyChanged(ProductMetadata.PropertyNames.Unitprice);
				}
			}
		}		
		
		/// <summary>
		/// Maps to product.unitsinstock
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int16? Unitsinstock
		{
			get
			{
				return base.GetSystemInt16(ProductMetadata.ColumnNames.Unitsinstock);
			}
			
			set
			{
				if(base.SetSystemInt16(ProductMetadata.ColumnNames.Unitsinstock, value))
				{
					OnPropertyChanged(ProductMetadata.PropertyNames.Unitsinstock);
				}
			}
		}		
		
		/// <summary>
		/// Maps to product.unitsonorder
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int16? Unitsonorder
		{
			get
			{
				return base.GetSystemInt16(ProductMetadata.ColumnNames.Unitsonorder);
			}
			
			set
			{
				if(base.SetSystemInt16(ProductMetadata.ColumnNames.Unitsonorder, value))
				{
					OnPropertyChanged(ProductMetadata.PropertyNames.Unitsonorder);
				}
			}
		}		
		
		/// <summary>
		/// Maps to product.reorderlevel
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int16? Reorderlevel
		{
			get
			{
				return base.GetSystemInt16(ProductMetadata.ColumnNames.Reorderlevel);
			}
			
			set
			{
				if(base.SetSystemInt16(ProductMetadata.ColumnNames.Reorderlevel, value))
				{
					OnPropertyChanged(ProductMetadata.PropertyNames.Reorderlevel);
				}
			}
		}		
		
		/// <summary>
		/// Maps to product.discontinued
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Discontinued
		{
			get
			{
				return base.GetSystemString(ProductMetadata.ColumnNames.Discontinued);
			}
			
			set
			{
				if(base.SetSystemString(ProductMetadata.ColumnNames.Discontinued, value))
				{
					OnPropertyChanged(ProductMetadata.PropertyNames.Discontinued);
				}
			}
		}		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return ProductMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public ProductQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ProductQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ProductQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(ProductQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private ProductQuery query;		
	}



	[Serializable]
	abstract public partial class esProductCollection : esEntityCollection<Product>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return ProductMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "ProductCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public ProductQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ProductQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ProductQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new ProductQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(ProductQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((ProductQuery)query);
		}

		#endregion
		
		private ProductQuery query;
	}



	[Serializable]
	abstract public partial class esProductQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return ProductMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Productid": return this.Productid;
				case "Productname": return this.Productname;
				case "Supplierid": return this.Supplierid;
				case "Categoryid": return this.Categoryid;
				case "Quantityperunit": return this.Quantityperunit;
				case "Unitprice": return this.Unitprice;
				case "Unitsinstock": return this.Unitsinstock;
				case "Unitsonorder": return this.Unitsonorder;
				case "Reorderlevel": return this.Reorderlevel;
				case "Discontinued": return this.Discontinued;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Productid
		{
			get { return new esQueryItem(this, ProductMetadata.ColumnNames.Productid, esSystemType.Int32); }
		} 
		
		public esQueryItem Productname
		{
			get { return new esQueryItem(this, ProductMetadata.ColumnNames.Productname, esSystemType.String); }
		} 
		
		public esQueryItem Supplierid
		{
			get { return new esQueryItem(this, ProductMetadata.ColumnNames.Supplierid, esSystemType.Int32); }
		} 
		
		public esQueryItem Categoryid
		{
			get { return new esQueryItem(this, ProductMetadata.ColumnNames.Categoryid, esSystemType.Int32); }
		} 
		
		public esQueryItem Quantityperunit
		{
			get { return new esQueryItem(this, ProductMetadata.ColumnNames.Quantityperunit, esSystemType.String); }
		} 
		
		public esQueryItem Unitprice
		{
			get { return new esQueryItem(this, ProductMetadata.ColumnNames.Unitprice, esSystemType.Decimal); }
		} 
		
		public esQueryItem Unitsinstock
		{
			get { return new esQueryItem(this, ProductMetadata.ColumnNames.Unitsinstock, esSystemType.Int16); }
		} 
		
		public esQueryItem Unitsonorder
		{
			get { return new esQueryItem(this, ProductMetadata.ColumnNames.Unitsonorder, esSystemType.Int16); }
		} 
		
		public esQueryItem Reorderlevel
		{
			get { return new esQueryItem(this, ProductMetadata.ColumnNames.Reorderlevel, esSystemType.Int16); }
		} 
		
		public esQueryItem Discontinued
		{
			get { return new esQueryItem(this, ProductMetadata.ColumnNames.Discontinued, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class Product : esProduct
	{

		
		
	}
	



	[Serializable]
	public partial class ProductMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected ProductMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(ProductMetadata.ColumnNames.Productid, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ProductMetadata.PropertyNames.Productid;
			c.IsInPrimaryKey = true;
			c.NumericPrecision = 32;
			c.HasDefault = true;
			c.Default = @"nextval('product_productid_seq'::regclass)";
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProductMetadata.ColumnNames.Productname, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = ProductMetadata.PropertyNames.Productname;
			c.CharacterMaxLength = 40;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProductMetadata.ColumnNames.Supplierid, 2, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ProductMetadata.PropertyNames.Supplierid;
			c.NumericPrecision = 32;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProductMetadata.ColumnNames.Categoryid, 3, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ProductMetadata.PropertyNames.Categoryid;
			c.NumericPrecision = 32;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProductMetadata.ColumnNames.Quantityperunit, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = ProductMetadata.PropertyNames.Quantityperunit;
			c.CharacterMaxLength = 20;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProductMetadata.ColumnNames.Unitprice, 5, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = ProductMetadata.PropertyNames.Unitprice;
			c.NumericPrecision = 10;
			c.NumericScale = 2;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProductMetadata.ColumnNames.Unitsinstock, 6, typeof(System.Int16), esSystemType.Int16);
			c.PropertyName = ProductMetadata.PropertyNames.Unitsinstock;
			c.NumericPrecision = 16;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProductMetadata.ColumnNames.Unitsonorder, 7, typeof(System.Int16), esSystemType.Int16);
			c.PropertyName = ProductMetadata.PropertyNames.Unitsonorder;
			c.NumericPrecision = 16;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProductMetadata.ColumnNames.Reorderlevel, 8, typeof(System.Int16), esSystemType.Int16);
			c.PropertyName = ProductMetadata.PropertyNames.Reorderlevel;
			c.NumericPrecision = 16;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProductMetadata.ColumnNames.Discontinued, 9, typeof(System.String), esSystemType.String);
			c.PropertyName = ProductMetadata.PropertyNames.Discontinued;
			c.CharacterMaxLength = 1;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public ProductMetadata Meta()
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
			 public const string Productid = "productid";
			 public const string Productname = "productname";
			 public const string Supplierid = "supplierid";
			 public const string Categoryid = "categoryid";
			 public const string Quantityperunit = "quantityperunit";
			 public const string Unitprice = "unitprice";
			 public const string Unitsinstock = "unitsinstock";
			 public const string Unitsonorder = "unitsonorder";
			 public const string Reorderlevel = "reorderlevel";
			 public const string Discontinued = "discontinued";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Productid = "Productid";
			 public const string Productname = "Productname";
			 public const string Supplierid = "Supplierid";
			 public const string Categoryid = "Categoryid";
			 public const string Quantityperunit = "Quantityperunit";
			 public const string Unitprice = "Unitprice";
			 public const string Unitsinstock = "Unitsinstock";
			 public const string Unitsonorder = "Unitsonorder";
			 public const string Reorderlevel = "Reorderlevel";
			 public const string Discontinued = "Discontinued";
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
			lock (typeof(ProductMetadata))
			{
				if(ProductMetadata.mapDelegates == null)
				{
					ProductMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (ProductMetadata.meta == null)
				{
					ProductMetadata.meta = new ProductMetadata();
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


				meta.AddTypeMap("Productid", new esTypeMap("int4", "System.Int32"));
				meta.AddTypeMap("Productname", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Supplierid", new esTypeMap("int4", "System.Int32"));
				meta.AddTypeMap("Categoryid", new esTypeMap("int4", "System.Int32"));
				meta.AddTypeMap("Quantityperunit", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Unitprice", new esTypeMap("numeric", "System.Decimal"));
				meta.AddTypeMap("Unitsinstock", new esTypeMap("int2", "System.Int16"));
				meta.AddTypeMap("Unitsonorder", new esTypeMap("int2", "System.Int16"));
				meta.AddTypeMap("Reorderlevel", new esTypeMap("int2", "System.Int16"));
				meta.AddTypeMap("Discontinued", new esTypeMap("bpchar", "System.String"));			
				
				
				
				meta.Source = "product";
				meta.Destination = "product";
				
				meta.spInsert = "proc_productInsert";				
				meta.spUpdate = "proc_productUpdate";		
				meta.spDelete = "proc_productDelete";
				meta.spLoadAll = "proc_productLoadAll";
				meta.spLoadByPrimaryKey = "proc_productLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private ProductMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
