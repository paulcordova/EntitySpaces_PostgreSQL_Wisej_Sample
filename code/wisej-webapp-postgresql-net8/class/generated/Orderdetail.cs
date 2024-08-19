
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2024.3.0001.1
EntitySpaces Driver  : PostgreSQL
Date Generated       : 18-08-2024 17:47:34
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
	/// Encapsulates the 'orderdetail' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(Orderdetail))]	
	[XmlType("Orderdetail")]
	public partial class Orderdetail : esOrderdetail
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new Orderdetail();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 entityid)
		{
			var obj = new Orderdetail();
			obj.Entityid = entityid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 entityid, esSqlAccessType sqlAccessType)
		{
			var obj = new Orderdetail();
			obj.Entityid = entityid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("OrderdetailCollection")]
	public partial class OrderdetailCollection : esOrderdetailCollection, IEnumerable<Orderdetail>
	{
		public Orderdetail FindByPrimaryKey(System.Int32 entityid)
		{
			return this.SingleOrDefault(e => e.Entityid == entityid);
		}

		
				
	}



	[Serializable]	
	public partial class OrderdetailQuery : esOrderdetailQuery
	{
		public OrderdetailQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public OrderdetailQuery(string joinAlias, out OrderdetailQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "OrderdetailQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(OrderdetailQuery query)
		{
			return OrderdetailQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator OrderdetailQuery(string query)
		{
			return (OrderdetailQuery)OrderdetailQuery.SerializeHelper.FromXml(query, typeof(OrderdetailQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esOrderdetail : esEntity
	{
		public esOrderdetail()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 entityid)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(entityid);
			else
				return LoadByPrimaryKeyStoredProcedure(entityid);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 entityid)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(entityid);
			else
				return LoadByPrimaryKeyStoredProcedure(entityid);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 entityid)
		{
			OrderdetailQuery query = new OrderdetailQuery();
			query.Where(query.Entityid == entityid);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 entityid)
		{
			esParameters parms = new esParameters();
			parms.Add("Entityid", entityid);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to orderdetail.entityid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Entityid
		{
			get
			{
				return base.GetSystemInt32(OrderdetailMetadata.ColumnNames.Entityid);
			}
			
			set
			{
				if(base.SetSystemInt32(OrderdetailMetadata.ColumnNames.Entityid, value))
				{
					OnPropertyChanged(OrderdetailMetadata.PropertyNames.Entityid);
				}
			}
		}		
		
		/// <summary>
		/// Maps to orderdetail.orderid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Orderid
		{
			get
			{
				return base.GetSystemInt32(OrderdetailMetadata.ColumnNames.Orderid);
			}
			
			set
			{
				if(base.SetSystemInt32(OrderdetailMetadata.ColumnNames.Orderid, value))
				{
					OnPropertyChanged(OrderdetailMetadata.PropertyNames.Orderid);
				}
			}
		}		
		
		/// <summary>
		/// Maps to orderdetail.productid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Productid
		{
			get
			{
				return base.GetSystemInt32(OrderdetailMetadata.ColumnNames.Productid);
			}
			
			set
			{
				if(base.SetSystemInt32(OrderdetailMetadata.ColumnNames.Productid, value))
				{
					OnPropertyChanged(OrderdetailMetadata.PropertyNames.Productid);
				}
			}
		}		
		
		/// <summary>
		/// Maps to orderdetail.unitprice
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? Unitprice
		{
			get
			{
				return base.GetSystemDecimal(OrderdetailMetadata.ColumnNames.Unitprice);
			}
			
			set
			{
				if(base.SetSystemDecimal(OrderdetailMetadata.ColumnNames.Unitprice, value))
				{
					OnPropertyChanged(OrderdetailMetadata.PropertyNames.Unitprice);
				}
			}
		}		
		
		/// <summary>
		/// Maps to orderdetail.qty
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int16? Qty
		{
			get
			{
				return base.GetSystemInt16(OrderdetailMetadata.ColumnNames.Qty);
			}
			
			set
			{
				if(base.SetSystemInt16(OrderdetailMetadata.ColumnNames.Qty, value))
				{
					OnPropertyChanged(OrderdetailMetadata.PropertyNames.Qty);
				}
			}
		}		
		
		/// <summary>
		/// Maps to orderdetail.discount
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? Discount
		{
			get
			{
				return base.GetSystemDecimal(OrderdetailMetadata.ColumnNames.Discount);
			}
			
			set
			{
				if(base.SetSystemDecimal(OrderdetailMetadata.ColumnNames.Discount, value))
				{
					OnPropertyChanged(OrderdetailMetadata.PropertyNames.Discount);
				}
			}
		}		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return OrderdetailMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public OrderdetailQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new OrderdetailQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(OrderdetailQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(OrderdetailQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private OrderdetailQuery query;		
	}



	[Serializable]
	abstract public partial class esOrderdetailCollection : esEntityCollection<Orderdetail>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return OrderdetailMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "OrderdetailCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public OrderdetailQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new OrderdetailQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(OrderdetailQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new OrderdetailQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(OrderdetailQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((OrderdetailQuery)query);
		}

		#endregion
		
		private OrderdetailQuery query;
	}



	[Serializable]
	abstract public partial class esOrderdetailQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return OrderdetailMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Entityid": return this.Entityid;
				case "Orderid": return this.Orderid;
				case "Productid": return this.Productid;
				case "Unitprice": return this.Unitprice;
				case "Qty": return this.Qty;
				case "Discount": return this.Discount;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Entityid
		{
			get { return new esQueryItem(this, OrderdetailMetadata.ColumnNames.Entityid, esSystemType.Int32); }
		} 
		
		public esQueryItem Orderid
		{
			get { return new esQueryItem(this, OrderdetailMetadata.ColumnNames.Orderid, esSystemType.Int32); }
		} 
		
		public esQueryItem Productid
		{
			get { return new esQueryItem(this, OrderdetailMetadata.ColumnNames.Productid, esSystemType.Int32); }
		} 
		
		public esQueryItem Unitprice
		{
			get { return new esQueryItem(this, OrderdetailMetadata.ColumnNames.Unitprice, esSystemType.Decimal); }
		} 
		
		public esQueryItem Qty
		{
			get { return new esQueryItem(this, OrderdetailMetadata.ColumnNames.Qty, esSystemType.Int16); }
		} 
		
		public esQueryItem Discount
		{
			get { return new esQueryItem(this, OrderdetailMetadata.ColumnNames.Discount, esSystemType.Decimal); }
		} 
		
		#endregion
		
	}


	
	public partial class Orderdetail : esOrderdetail
	{

		
		
	}
	



	[Serializable]
	public partial class OrderdetailMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected OrderdetailMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(OrderdetailMetadata.ColumnNames.Entityid, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = OrderdetailMetadata.PropertyNames.Entityid;
			c.IsInPrimaryKey = true;
			c.NumericPrecision = 32;
			c.HasDefault = true;
			c.Default = @"nextval('orderdetail_entityid_seq'::regclass)";
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrderdetailMetadata.ColumnNames.Orderid, 1, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = OrderdetailMetadata.PropertyNames.Orderid;
			c.NumericPrecision = 32;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrderdetailMetadata.ColumnNames.Productid, 2, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = OrderdetailMetadata.PropertyNames.Productid;
			c.NumericPrecision = 32;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrderdetailMetadata.ColumnNames.Unitprice, 3, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = OrderdetailMetadata.PropertyNames.Unitprice;
			c.NumericPrecision = 10;
			c.NumericScale = 2;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrderdetailMetadata.ColumnNames.Qty, 4, typeof(System.Int16), esSystemType.Int16);
			c.PropertyName = OrderdetailMetadata.PropertyNames.Qty;
			c.NumericPrecision = 16;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrderdetailMetadata.ColumnNames.Discount, 5, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = OrderdetailMetadata.PropertyNames.Discount;
			c.NumericPrecision = 10;
			c.NumericScale = 2;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public OrderdetailMetadata Meta()
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
			 public const string Entityid = "entityid";
			 public const string Orderid = "orderid";
			 public const string Productid = "productid";
			 public const string Unitprice = "unitprice";
			 public const string Qty = "qty";
			 public const string Discount = "discount";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Entityid = "Entityid";
			 public const string Orderid = "Orderid";
			 public const string Productid = "Productid";
			 public const string Unitprice = "Unitprice";
			 public const string Qty = "Qty";
			 public const string Discount = "Discount";
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
			lock (typeof(OrderdetailMetadata))
			{
				if(OrderdetailMetadata.mapDelegates == null)
				{
					OrderdetailMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (OrderdetailMetadata.meta == null)
				{
					OrderdetailMetadata.meta = new OrderdetailMetadata();
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


				meta.AddTypeMap("Entityid", new esTypeMap("int4", "System.Int32"));
				meta.AddTypeMap("Orderid", new esTypeMap("int4", "System.Int32"));
				meta.AddTypeMap("Productid", new esTypeMap("int4", "System.Int32"));
				meta.AddTypeMap("Unitprice", new esTypeMap("numeric", "System.Decimal"));
				meta.AddTypeMap("Qty", new esTypeMap("int2", "System.Int16"));
				meta.AddTypeMap("Discount", new esTypeMap("numeric", "System.Decimal"));			
				
				
				
				meta.Source = "orderdetail";
				meta.Destination = "orderdetail";
				
				meta.spInsert = "proc_orderdetailInsert";				
				meta.spUpdate = "proc_orderdetailUpdate";		
				meta.spDelete = "proc_orderdetailDelete";
				meta.spLoadAll = "proc_orderdetailLoadAll";
				meta.spLoadByPrimaryKey = "proc_orderdetailLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private OrderdetailMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
