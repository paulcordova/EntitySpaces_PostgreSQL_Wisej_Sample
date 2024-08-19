
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2024.3.0001.1
EntitySpaces Driver  : PostgreSQL
Date Generated       : 18-08-2024 17:47:41
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
	/// Encapsulates the 'shipper' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(Shipper))]	
	[XmlType("Shipper")]
	public partial class Shipper : esShipper
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new Shipper();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 shipperid)
		{
			var obj = new Shipper();
			obj.Shipperid = shipperid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 shipperid, esSqlAccessType sqlAccessType)
		{
			var obj = new Shipper();
			obj.Shipperid = shipperid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("ShipperCollection")]
	public partial class ShipperCollection : esShipperCollection, IEnumerable<Shipper>
	{
		public Shipper FindByPrimaryKey(System.Int32 shipperid)
		{
			return this.SingleOrDefault(e => e.Shipperid == shipperid);
		}

		
				
	}



	[Serializable]	
	public partial class ShipperQuery : esShipperQuery
	{
		public ShipperQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public ShipperQuery(string joinAlias, out ShipperQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "ShipperQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(ShipperQuery query)
		{
			return ShipperQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator ShipperQuery(string query)
		{
			return (ShipperQuery)ShipperQuery.SerializeHelper.FromXml(query, typeof(ShipperQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esShipper : esEntity
	{
		public esShipper()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 shipperid)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(shipperid);
			else
				return LoadByPrimaryKeyStoredProcedure(shipperid);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 shipperid)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(shipperid);
			else
				return LoadByPrimaryKeyStoredProcedure(shipperid);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 shipperid)
		{
			ShipperQuery query = new ShipperQuery();
			query.Where(query.Shipperid == shipperid);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 shipperid)
		{
			esParameters parms = new esParameters();
			parms.Add("Shipperid", shipperid);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to shipper.shipperid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Shipperid
		{
			get
			{
				return base.GetSystemInt32(ShipperMetadata.ColumnNames.Shipperid);
			}
			
			set
			{
				if(base.SetSystemInt32(ShipperMetadata.ColumnNames.Shipperid, value))
				{
					OnPropertyChanged(ShipperMetadata.PropertyNames.Shipperid);
				}
			}
		}		
		
		/// <summary>
		/// Maps to shipper.companyname
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Companyname
		{
			get
			{
				return base.GetSystemString(ShipperMetadata.ColumnNames.Companyname);
			}
			
			set
			{
				if(base.SetSystemString(ShipperMetadata.ColumnNames.Companyname, value))
				{
					OnPropertyChanged(ShipperMetadata.PropertyNames.Companyname);
				}
			}
		}		
		
		/// <summary>
		/// Maps to shipper.phone
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Phone
		{
			get
			{
				return base.GetSystemString(ShipperMetadata.ColumnNames.Phone);
			}
			
			set
			{
				if(base.SetSystemString(ShipperMetadata.ColumnNames.Phone, value))
				{
					OnPropertyChanged(ShipperMetadata.PropertyNames.Phone);
				}
			}
		}		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return ShipperMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public ShipperQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ShipperQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ShipperQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(ShipperQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private ShipperQuery query;		
	}



	[Serializable]
	abstract public partial class esShipperCollection : esEntityCollection<Shipper>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return ShipperMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "ShipperCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public ShipperQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ShipperQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ShipperQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new ShipperQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(ShipperQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((ShipperQuery)query);
		}

		#endregion
		
		private ShipperQuery query;
	}



	[Serializable]
	abstract public partial class esShipperQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return ShipperMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Shipperid": return this.Shipperid;
				case "Companyname": return this.Companyname;
				case "Phone": return this.Phone;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Shipperid
		{
			get { return new esQueryItem(this, ShipperMetadata.ColumnNames.Shipperid, esSystemType.Int32); }
		} 
		
		public esQueryItem Companyname
		{
			get { return new esQueryItem(this, ShipperMetadata.ColumnNames.Companyname, esSystemType.String); }
		} 
		
		public esQueryItem Phone
		{
			get { return new esQueryItem(this, ShipperMetadata.ColumnNames.Phone, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class Shipper : esShipper
	{

		
		
	}
	



	[Serializable]
	public partial class ShipperMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected ShipperMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(ShipperMetadata.ColumnNames.Shipperid, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ShipperMetadata.PropertyNames.Shipperid;
			c.IsInPrimaryKey = true;
			c.NumericPrecision = 32;
			c.HasDefault = true;
			c.Default = @"nextval('shipper_shipperid_seq'::regclass)";
			m_columns.Add(c);
				
			c = new esColumnMetadata(ShipperMetadata.ColumnNames.Companyname, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = ShipperMetadata.PropertyNames.Companyname;
			c.CharacterMaxLength = 40;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ShipperMetadata.ColumnNames.Phone, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = ShipperMetadata.PropertyNames.Phone;
			c.CharacterMaxLength = 44;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public ShipperMetadata Meta()
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
			 public const string Shipperid = "shipperid";
			 public const string Companyname = "companyname";
			 public const string Phone = "phone";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Shipperid = "Shipperid";
			 public const string Companyname = "Companyname";
			 public const string Phone = "Phone";
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
			lock (typeof(ShipperMetadata))
			{
				if(ShipperMetadata.mapDelegates == null)
				{
					ShipperMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (ShipperMetadata.meta == null)
				{
					ShipperMetadata.meta = new ShipperMetadata();
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


				meta.AddTypeMap("Shipperid", new esTypeMap("int4", "System.Int32"));
				meta.AddTypeMap("Companyname", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Phone", new esTypeMap("varchar", "System.String"));			
				
				
				
				meta.Source = "shipper";
				meta.Destination = "shipper";
				
				meta.spInsert = "proc_shipperInsert";				
				meta.spUpdate = "proc_shipperUpdate";		
				meta.spDelete = "proc_shipperDelete";
				meta.spLoadAll = "proc_shipperLoadAll";
				meta.spLoadByPrimaryKey = "proc_shipperLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private ShipperMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
