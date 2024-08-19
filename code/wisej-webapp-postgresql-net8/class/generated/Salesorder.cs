
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2024.3.0001.1
EntitySpaces Driver  : PostgreSQL
Date Generated       : 18-08-2024 17:47:39
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
	/// Encapsulates the 'salesorder' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(Salesorder))]	
	[XmlType("Salesorder")]
	public partial class Salesorder : esSalesorder
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new Salesorder();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 orderid)
		{
			var obj = new Salesorder();
			obj.Orderid = orderid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 orderid, esSqlAccessType sqlAccessType)
		{
			var obj = new Salesorder();
			obj.Orderid = orderid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("SalesorderCollection")]
	public partial class SalesorderCollection : esSalesorderCollection, IEnumerable<Salesorder>
	{
		public Salesorder FindByPrimaryKey(System.Int32 orderid)
		{
			return this.SingleOrDefault(e => e.Orderid == orderid);
		}

		
				
	}



	[Serializable]	
	public partial class SalesorderQuery : esSalesorderQuery
	{
		public SalesorderQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public SalesorderQuery(string joinAlias, out SalesorderQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "SalesorderQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(SalesorderQuery query)
		{
			return SalesorderQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator SalesorderQuery(string query)
		{
			return (SalesorderQuery)SalesorderQuery.SerializeHelper.FromXml(query, typeof(SalesorderQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esSalesorder : esEntity
	{
		public esSalesorder()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 orderid)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(orderid);
			else
				return LoadByPrimaryKeyStoredProcedure(orderid);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 orderid)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(orderid);
			else
				return LoadByPrimaryKeyStoredProcedure(orderid);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 orderid)
		{
			SalesorderQuery query = new SalesorderQuery();
			query.Where(query.Orderid == orderid);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 orderid)
		{
			esParameters parms = new esParameters();
			parms.Add("Orderid", orderid);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to salesorder.orderid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Orderid
		{
			get
			{
				return base.GetSystemInt32(SalesorderMetadata.ColumnNames.Orderid);
			}
			
			set
			{
				if(base.SetSystemInt32(SalesorderMetadata.ColumnNames.Orderid, value))
				{
					OnPropertyChanged(SalesorderMetadata.PropertyNames.Orderid);
				}
			}
		}		
		
		/// <summary>
		/// Maps to salesorder.custid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Custid
		{
			get
			{
				return base.GetSystemString(SalesorderMetadata.ColumnNames.Custid);
			}
			
			set
			{
				if(base.SetSystemString(SalesorderMetadata.ColumnNames.Custid, value))
				{
					OnPropertyChanged(SalesorderMetadata.PropertyNames.Custid);
				}
			}
		}		
		
		/// <summary>
		/// Maps to salesorder.empid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Empid
		{
			get
			{
				return base.GetSystemInt32(SalesorderMetadata.ColumnNames.Empid);
			}
			
			set
			{
				if(base.SetSystemInt32(SalesorderMetadata.ColumnNames.Empid, value))
				{
					OnPropertyChanged(SalesorderMetadata.PropertyNames.Empid);
				}
			}
		}		
		
		/// <summary>
		/// Maps to salesorder.orderdate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? Orderdate
		{
			get
			{
				return base.GetSystemDateTime(SalesorderMetadata.ColumnNames.Orderdate);
			}
			
			set
			{
				if(base.SetSystemDateTime(SalesorderMetadata.ColumnNames.Orderdate, value))
				{
					OnPropertyChanged(SalesorderMetadata.PropertyNames.Orderdate);
				}
			}
		}		
		
		/// <summary>
		/// Maps to salesorder.requireddate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? Requireddate
		{
			get
			{
				return base.GetSystemDateTime(SalesorderMetadata.ColumnNames.Requireddate);
			}
			
			set
			{
				if(base.SetSystemDateTime(SalesorderMetadata.ColumnNames.Requireddate, value))
				{
					OnPropertyChanged(SalesorderMetadata.PropertyNames.Requireddate);
				}
			}
		}		
		
		/// <summary>
		/// Maps to salesorder.shippeddate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? Shippeddate
		{
			get
			{
				return base.GetSystemDateTime(SalesorderMetadata.ColumnNames.Shippeddate);
			}
			
			set
			{
				if(base.SetSystemDateTime(SalesorderMetadata.ColumnNames.Shippeddate, value))
				{
					OnPropertyChanged(SalesorderMetadata.PropertyNames.Shippeddate);
				}
			}
		}		
		
		/// <summary>
		/// Maps to salesorder.shipperid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Shipperid
		{
			get
			{
				return base.GetSystemInt32(SalesorderMetadata.ColumnNames.Shipperid);
			}
			
			set
			{
				if(base.SetSystemInt32(SalesorderMetadata.ColumnNames.Shipperid, value))
				{
					OnPropertyChanged(SalesorderMetadata.PropertyNames.Shipperid);
				}
			}
		}		
		
		/// <summary>
		/// Maps to salesorder.freight
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? Freight
		{
			get
			{
				return base.GetSystemDecimal(SalesorderMetadata.ColumnNames.Freight);
			}
			
			set
			{
				if(base.SetSystemDecimal(SalesorderMetadata.ColumnNames.Freight, value))
				{
					OnPropertyChanged(SalesorderMetadata.PropertyNames.Freight);
				}
			}
		}		
		
		/// <summary>
		/// Maps to salesorder.shipname
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Shipname
		{
			get
			{
				return base.GetSystemString(SalesorderMetadata.ColumnNames.Shipname);
			}
			
			set
			{
				if(base.SetSystemString(SalesorderMetadata.ColumnNames.Shipname, value))
				{
					OnPropertyChanged(SalesorderMetadata.PropertyNames.Shipname);
				}
			}
		}		
		
		/// <summary>
		/// Maps to salesorder.shipaddress
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Shipaddress
		{
			get
			{
				return base.GetSystemString(SalesorderMetadata.ColumnNames.Shipaddress);
			}
			
			set
			{
				if(base.SetSystemString(SalesorderMetadata.ColumnNames.Shipaddress, value))
				{
					OnPropertyChanged(SalesorderMetadata.PropertyNames.Shipaddress);
				}
			}
		}		
		
		/// <summary>
		/// Maps to salesorder.shipcity
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Shipcity
		{
			get
			{
				return base.GetSystemString(SalesorderMetadata.ColumnNames.Shipcity);
			}
			
			set
			{
				if(base.SetSystemString(SalesorderMetadata.ColumnNames.Shipcity, value))
				{
					OnPropertyChanged(SalesorderMetadata.PropertyNames.Shipcity);
				}
			}
		}		
		
		/// <summary>
		/// Maps to salesorder.shipregion
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Shipregion
		{
			get
			{
				return base.GetSystemString(SalesorderMetadata.ColumnNames.Shipregion);
			}
			
			set
			{
				if(base.SetSystemString(SalesorderMetadata.ColumnNames.Shipregion, value))
				{
					OnPropertyChanged(SalesorderMetadata.PropertyNames.Shipregion);
				}
			}
		}		
		
		/// <summary>
		/// Maps to salesorder.shippostalcode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Shippostalcode
		{
			get
			{
				return base.GetSystemString(SalesorderMetadata.ColumnNames.Shippostalcode);
			}
			
			set
			{
				if(base.SetSystemString(SalesorderMetadata.ColumnNames.Shippostalcode, value))
				{
					OnPropertyChanged(SalesorderMetadata.PropertyNames.Shippostalcode);
				}
			}
		}		
		
		/// <summary>
		/// Maps to salesorder.shipcountry
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Shipcountry
		{
			get
			{
				return base.GetSystemString(SalesorderMetadata.ColumnNames.Shipcountry);
			}
			
			set
			{
				if(base.SetSystemString(SalesorderMetadata.ColumnNames.Shipcountry, value))
				{
					OnPropertyChanged(SalesorderMetadata.PropertyNames.Shipcountry);
				}
			}
		}		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return SalesorderMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public SalesorderQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new SalesorderQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(SalesorderQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(SalesorderQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private SalesorderQuery query;		
	}



	[Serializable]
	abstract public partial class esSalesorderCollection : esEntityCollection<Salesorder>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return SalesorderMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "SalesorderCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public SalesorderQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new SalesorderQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(SalesorderQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new SalesorderQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(SalesorderQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((SalesorderQuery)query);
		}

		#endregion
		
		private SalesorderQuery query;
	}



	[Serializable]
	abstract public partial class esSalesorderQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return SalesorderMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Orderid": return this.Orderid;
				case "Custid": return this.Custid;
				case "Empid": return this.Empid;
				case "Orderdate": return this.Orderdate;
				case "Requireddate": return this.Requireddate;
				case "Shippeddate": return this.Shippeddate;
				case "Shipperid": return this.Shipperid;
				case "Freight": return this.Freight;
				case "Shipname": return this.Shipname;
				case "Shipaddress": return this.Shipaddress;
				case "Shipcity": return this.Shipcity;
				case "Shipregion": return this.Shipregion;
				case "Shippostalcode": return this.Shippostalcode;
				case "Shipcountry": return this.Shipcountry;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Orderid
		{
			get { return new esQueryItem(this, SalesorderMetadata.ColumnNames.Orderid, esSystemType.Int32); }
		} 
		
		public esQueryItem Custid
		{
			get { return new esQueryItem(this, SalesorderMetadata.ColumnNames.Custid, esSystemType.String); }
		} 
		
		public esQueryItem Empid
		{
			get { return new esQueryItem(this, SalesorderMetadata.ColumnNames.Empid, esSystemType.Int32); }
		} 
		
		public esQueryItem Orderdate
		{
			get { return new esQueryItem(this, SalesorderMetadata.ColumnNames.Orderdate, esSystemType.DateTime); }
		} 
		
		public esQueryItem Requireddate
		{
			get { return new esQueryItem(this, SalesorderMetadata.ColumnNames.Requireddate, esSystemType.DateTime); }
		} 
		
		public esQueryItem Shippeddate
		{
			get { return new esQueryItem(this, SalesorderMetadata.ColumnNames.Shippeddate, esSystemType.DateTime); }
		} 
		
		public esQueryItem Shipperid
		{
			get { return new esQueryItem(this, SalesorderMetadata.ColumnNames.Shipperid, esSystemType.Int32); }
		} 
		
		public esQueryItem Freight
		{
			get { return new esQueryItem(this, SalesorderMetadata.ColumnNames.Freight, esSystemType.Decimal); }
		} 
		
		public esQueryItem Shipname
		{
			get { return new esQueryItem(this, SalesorderMetadata.ColumnNames.Shipname, esSystemType.String); }
		} 
		
		public esQueryItem Shipaddress
		{
			get { return new esQueryItem(this, SalesorderMetadata.ColumnNames.Shipaddress, esSystemType.String); }
		} 
		
		public esQueryItem Shipcity
		{
			get { return new esQueryItem(this, SalesorderMetadata.ColumnNames.Shipcity, esSystemType.String); }
		} 
		
		public esQueryItem Shipregion
		{
			get { return new esQueryItem(this, SalesorderMetadata.ColumnNames.Shipregion, esSystemType.String); }
		} 
		
		public esQueryItem Shippostalcode
		{
			get { return new esQueryItem(this, SalesorderMetadata.ColumnNames.Shippostalcode, esSystemType.String); }
		} 
		
		public esQueryItem Shipcountry
		{
			get { return new esQueryItem(this, SalesorderMetadata.ColumnNames.Shipcountry, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class Salesorder : esSalesorder
	{

		
		
	}
	



	[Serializable]
	public partial class SalesorderMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected SalesorderMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(SalesorderMetadata.ColumnNames.Orderid, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = SalesorderMetadata.PropertyNames.Orderid;
			c.IsInPrimaryKey = true;
			c.NumericPrecision = 32;
			c.HasDefault = true;
			c.Default = @"nextval('salesorder_orderid_seq'::regclass)";
			m_columns.Add(c);
				
			c = new esColumnMetadata(SalesorderMetadata.ColumnNames.Custid, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = SalesorderMetadata.PropertyNames.Custid;
			c.CharacterMaxLength = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SalesorderMetadata.ColumnNames.Empid, 2, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = SalesorderMetadata.PropertyNames.Empid;
			c.NumericPrecision = 32;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SalesorderMetadata.ColumnNames.Orderdate, 3, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = SalesorderMetadata.PropertyNames.Orderdate;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SalesorderMetadata.ColumnNames.Requireddate, 4, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = SalesorderMetadata.PropertyNames.Requireddate;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SalesorderMetadata.ColumnNames.Shippeddate, 5, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = SalesorderMetadata.PropertyNames.Shippeddate;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SalesorderMetadata.ColumnNames.Shipperid, 6, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = SalesorderMetadata.PropertyNames.Shipperid;
			c.NumericPrecision = 32;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SalesorderMetadata.ColumnNames.Freight, 7, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = SalesorderMetadata.PropertyNames.Freight;
			c.NumericPrecision = 10;
			c.NumericScale = 2;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SalesorderMetadata.ColumnNames.Shipname, 8, typeof(System.String), esSystemType.String);
			c.PropertyName = SalesorderMetadata.PropertyNames.Shipname;
			c.CharacterMaxLength = 40;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SalesorderMetadata.ColumnNames.Shipaddress, 9, typeof(System.String), esSystemType.String);
			c.PropertyName = SalesorderMetadata.PropertyNames.Shipaddress;
			c.CharacterMaxLength = 60;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SalesorderMetadata.ColumnNames.Shipcity, 10, typeof(System.String), esSystemType.String);
			c.PropertyName = SalesorderMetadata.PropertyNames.Shipcity;
			c.CharacterMaxLength = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SalesorderMetadata.ColumnNames.Shipregion, 11, typeof(System.String), esSystemType.String);
			c.PropertyName = SalesorderMetadata.PropertyNames.Shipregion;
			c.CharacterMaxLength = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SalesorderMetadata.ColumnNames.Shippostalcode, 12, typeof(System.String), esSystemType.String);
			c.PropertyName = SalesorderMetadata.PropertyNames.Shippostalcode;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SalesorderMetadata.ColumnNames.Shipcountry, 13, typeof(System.String), esSystemType.String);
			c.PropertyName = SalesorderMetadata.PropertyNames.Shipcountry;
			c.CharacterMaxLength = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public SalesorderMetadata Meta()
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
			 public const string Orderid = "orderid";
			 public const string Custid = "custid";
			 public const string Empid = "empid";
			 public const string Orderdate = "orderdate";
			 public const string Requireddate = "requireddate";
			 public const string Shippeddate = "shippeddate";
			 public const string Shipperid = "shipperid";
			 public const string Freight = "freight";
			 public const string Shipname = "shipname";
			 public const string Shipaddress = "shipaddress";
			 public const string Shipcity = "shipcity";
			 public const string Shipregion = "shipregion";
			 public const string Shippostalcode = "shippostalcode";
			 public const string Shipcountry = "shipcountry";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Orderid = "Orderid";
			 public const string Custid = "Custid";
			 public const string Empid = "Empid";
			 public const string Orderdate = "Orderdate";
			 public const string Requireddate = "Requireddate";
			 public const string Shippeddate = "Shippeddate";
			 public const string Shipperid = "Shipperid";
			 public const string Freight = "Freight";
			 public const string Shipname = "Shipname";
			 public const string Shipaddress = "Shipaddress";
			 public const string Shipcity = "Shipcity";
			 public const string Shipregion = "Shipregion";
			 public const string Shippostalcode = "Shippostalcode";
			 public const string Shipcountry = "Shipcountry";
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
			lock (typeof(SalesorderMetadata))
			{
				if(SalesorderMetadata.mapDelegates == null)
				{
					SalesorderMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (SalesorderMetadata.meta == null)
				{
					SalesorderMetadata.meta = new SalesorderMetadata();
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


				meta.AddTypeMap("Orderid", new esTypeMap("int4", "System.Int32"));
				meta.AddTypeMap("Custid", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Empid", new esTypeMap("int4", "System.Int32"));
				meta.AddTypeMap("Orderdate", new esTypeMap("timestamp", "System.DateTime"));
				meta.AddTypeMap("Requireddate", new esTypeMap("timestamp", "System.DateTime"));
				meta.AddTypeMap("Shippeddate", new esTypeMap("timestamp", "System.DateTime"));
				meta.AddTypeMap("Shipperid", new esTypeMap("int4", "System.Int32"));
				meta.AddTypeMap("Freight", new esTypeMap("numeric", "System.Decimal"));
				meta.AddTypeMap("Shipname", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Shipaddress", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Shipcity", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Shipregion", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Shippostalcode", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Shipcountry", new esTypeMap("varchar", "System.String"));			
				
				
				
				meta.Source = "salesorder";
				meta.Destination = "salesorder";
				
				meta.spInsert = "proc_salesorderInsert";				
				meta.spUpdate = "proc_salesorderUpdate";		
				meta.spDelete = "proc_salesorderDelete";
				meta.spLoadAll = "proc_salesorderLoadAll";
				meta.spLoadByPrimaryKey = "proc_salesorderLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private SalesorderMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
