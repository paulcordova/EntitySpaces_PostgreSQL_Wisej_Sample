
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2024.3.0001.1
EntitySpaces Driver  : PostgreSQL
Date Generated       : 18-08-2024 17:47:37
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
	/// Encapsulates the 'region' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(Region))]	
	[XmlType("Region")]
	public partial class Region : esRegion
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new Region();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 regionid)
		{
			var obj = new Region();
			obj.Regionid = regionid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 regionid, esSqlAccessType sqlAccessType)
		{
			var obj = new Region();
			obj.Regionid = regionid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("RegionCollection")]
	public partial class RegionCollection : esRegionCollection, IEnumerable<Region>
	{
		public Region FindByPrimaryKey(System.Int32 regionid)
		{
			return this.SingleOrDefault(e => e.Regionid == regionid);
		}

		
				
	}



	[Serializable]	
	public partial class RegionQuery : esRegionQuery
	{
		public RegionQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public RegionQuery(string joinAlias, out RegionQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "RegionQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(RegionQuery query)
		{
			return RegionQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator RegionQuery(string query)
		{
			return (RegionQuery)RegionQuery.SerializeHelper.FromXml(query, typeof(RegionQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esRegion : esEntity
	{
		public esRegion()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 regionid)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(regionid);
			else
				return LoadByPrimaryKeyStoredProcedure(regionid);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 regionid)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(regionid);
			else
				return LoadByPrimaryKeyStoredProcedure(regionid);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 regionid)
		{
			RegionQuery query = new RegionQuery();
			query.Where(query.Regionid == regionid);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 regionid)
		{
			esParameters parms = new esParameters();
			parms.Add("Regionid", regionid);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to region.regionid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Regionid
		{
			get
			{
				return base.GetSystemInt32(RegionMetadata.ColumnNames.Regionid);
			}
			
			set
			{
				if(base.SetSystemInt32(RegionMetadata.ColumnNames.Regionid, value))
				{
					OnPropertyChanged(RegionMetadata.PropertyNames.Regionid);
				}
			}
		}		
		
		/// <summary>
		/// Maps to region.regiondescription
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Regiondescription
		{
			get
			{
				return base.GetSystemString(RegionMetadata.ColumnNames.Regiondescription);
			}
			
			set
			{
				if(base.SetSystemString(RegionMetadata.ColumnNames.Regiondescription, value))
				{
					OnPropertyChanged(RegionMetadata.PropertyNames.Regiondescription);
				}
			}
		}		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return RegionMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public RegionQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new RegionQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(RegionQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(RegionQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private RegionQuery query;		
	}



	[Serializable]
	abstract public partial class esRegionCollection : esEntityCollection<Region>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return RegionMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "RegionCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public RegionQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new RegionQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(RegionQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new RegionQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(RegionQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((RegionQuery)query);
		}

		#endregion
		
		private RegionQuery query;
	}



	[Serializable]
	abstract public partial class esRegionQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return RegionMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Regionid": return this.Regionid;
				case "Regiondescription": return this.Regiondescription;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Regionid
		{
			get { return new esQueryItem(this, RegionMetadata.ColumnNames.Regionid, esSystemType.Int32); }
		} 
		
		public esQueryItem Regiondescription
		{
			get { return new esQueryItem(this, RegionMetadata.ColumnNames.Regiondescription, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class Region : esRegion
	{

		
		
	}
	



	[Serializable]
	public partial class RegionMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected RegionMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(RegionMetadata.ColumnNames.Regionid, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = RegionMetadata.PropertyNames.Regionid;
			c.IsInPrimaryKey = true;
			c.NumericPrecision = 32;
			m_columns.Add(c);
				
			c = new esColumnMetadata(RegionMetadata.ColumnNames.Regiondescription, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = RegionMetadata.PropertyNames.Regiondescription;
			c.CharacterMaxLength = 50;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public RegionMetadata Meta()
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
			 public const string Regionid = "regionid";
			 public const string Regiondescription = "regiondescription";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Regionid = "Regionid";
			 public const string Regiondescription = "Regiondescription";
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
			lock (typeof(RegionMetadata))
			{
				if(RegionMetadata.mapDelegates == null)
				{
					RegionMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (RegionMetadata.meta == null)
				{
					RegionMetadata.meta = new RegionMetadata();
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


				meta.AddTypeMap("Regionid", new esTypeMap("int4", "System.Int32"));
				meta.AddTypeMap("Regiondescription", new esTypeMap("varchar", "System.String"));			
				
				
				
				meta.Source = "region";
				meta.Destination = "region";
				
				meta.spInsert = "proc_regionInsert";				
				meta.spUpdate = "proc_regionUpdate";		
				meta.spDelete = "proc_regionDelete";
				meta.spLoadAll = "proc_regionLoadAll";
				meta.spLoadByPrimaryKey = "proc_regionLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private RegionMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
