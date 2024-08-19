
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2024.3.0001.1
EntitySpaces Driver  : PostgreSQL
Date Generated       : 18-08-2024 17:47:43
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
	/// Encapsulates the 'territory' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(Territory))]	
	[XmlType("Territory")]
	public partial class Territory : esTerritory
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new Territory();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.String territoryid)
		{
			var obj = new Territory();
			obj.Territoryid = territoryid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.String territoryid, esSqlAccessType sqlAccessType)
		{
			var obj = new Territory();
			obj.Territoryid = territoryid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("TerritoryCollection")]
	public partial class TerritoryCollection : esTerritoryCollection, IEnumerable<Territory>
	{
		public Territory FindByPrimaryKey(System.String territoryid)
		{
			return this.SingleOrDefault(e => e.Territoryid == territoryid);
		}

		
				
	}



	[Serializable]	
	public partial class TerritoryQuery : esTerritoryQuery
	{
		public TerritoryQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public TerritoryQuery(string joinAlias, out TerritoryQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "TerritoryQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(TerritoryQuery query)
		{
			return TerritoryQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator TerritoryQuery(string query)
		{
			return (TerritoryQuery)TerritoryQuery.SerializeHelper.FromXml(query, typeof(TerritoryQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esTerritory : esEntity
	{
		public esTerritory()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.String territoryid)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(territoryid);
			else
				return LoadByPrimaryKeyStoredProcedure(territoryid);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.String territoryid)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(territoryid);
			else
				return LoadByPrimaryKeyStoredProcedure(territoryid);
		}

		private bool LoadByPrimaryKeyDynamic(System.String territoryid)
		{
			TerritoryQuery query = new TerritoryQuery();
			query.Where(query.Territoryid == territoryid);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.String territoryid)
		{
			esParameters parms = new esParameters();
			parms.Add("Territoryid", territoryid);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to territory.territoryid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Territoryid
		{
			get
			{
				return base.GetSystemString(TerritoryMetadata.ColumnNames.Territoryid);
			}
			
			set
			{
				if(base.SetSystemString(TerritoryMetadata.ColumnNames.Territoryid, value))
				{
					OnPropertyChanged(TerritoryMetadata.PropertyNames.Territoryid);
				}
			}
		}		
		
		/// <summary>
		/// Maps to territory.territorydescription
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Territorydescription
		{
			get
			{
				return base.GetSystemString(TerritoryMetadata.ColumnNames.Territorydescription);
			}
			
			set
			{
				if(base.SetSystemString(TerritoryMetadata.ColumnNames.Territorydescription, value))
				{
					OnPropertyChanged(TerritoryMetadata.PropertyNames.Territorydescription);
				}
			}
		}		
		
		/// <summary>
		/// Maps to territory.regionid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Regionid
		{
			get
			{
				return base.GetSystemInt32(TerritoryMetadata.ColumnNames.Regionid);
			}
			
			set
			{
				if(base.SetSystemInt32(TerritoryMetadata.ColumnNames.Regionid, value))
				{
					OnPropertyChanged(TerritoryMetadata.PropertyNames.Regionid);
				}
			}
		}		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return TerritoryMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public TerritoryQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new TerritoryQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(TerritoryQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(TerritoryQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private TerritoryQuery query;		
	}



	[Serializable]
	abstract public partial class esTerritoryCollection : esEntityCollection<Territory>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return TerritoryMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "TerritoryCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public TerritoryQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new TerritoryQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(TerritoryQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new TerritoryQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(TerritoryQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((TerritoryQuery)query);
		}

		#endregion
		
		private TerritoryQuery query;
	}



	[Serializable]
	abstract public partial class esTerritoryQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return TerritoryMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Territoryid": return this.Territoryid;
				case "Territorydescription": return this.Territorydescription;
				case "Regionid": return this.Regionid;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Territoryid
		{
			get { return new esQueryItem(this, TerritoryMetadata.ColumnNames.Territoryid, esSystemType.String); }
		} 
		
		public esQueryItem Territorydescription
		{
			get { return new esQueryItem(this, TerritoryMetadata.ColumnNames.Territorydescription, esSystemType.String); }
		} 
		
		public esQueryItem Regionid
		{
			get { return new esQueryItem(this, TerritoryMetadata.ColumnNames.Regionid, esSystemType.Int32); }
		} 
		
		#endregion
		
	}


	
	public partial class Territory : esTerritory
	{

		
		
	}
	



	[Serializable]
	public partial class TerritoryMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected TerritoryMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(TerritoryMetadata.ColumnNames.Territoryid, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = TerritoryMetadata.PropertyNames.Territoryid;
			c.IsInPrimaryKey = true;
			c.CharacterMaxLength = 20;
			m_columns.Add(c);
				
			c = new esColumnMetadata(TerritoryMetadata.ColumnNames.Territorydescription, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = TerritoryMetadata.PropertyNames.Territorydescription;
			c.CharacterMaxLength = 50;
			m_columns.Add(c);
				
			c = new esColumnMetadata(TerritoryMetadata.ColumnNames.Regionid, 2, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = TerritoryMetadata.PropertyNames.Regionid;
			c.NumericPrecision = 32;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public TerritoryMetadata Meta()
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
			 public const string Territoryid = "territoryid";
			 public const string Territorydescription = "territorydescription";
			 public const string Regionid = "regionid";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Territoryid = "Territoryid";
			 public const string Territorydescription = "Territorydescription";
			 public const string Regionid = "Regionid";
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
			lock (typeof(TerritoryMetadata))
			{
				if(TerritoryMetadata.mapDelegates == null)
				{
					TerritoryMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (TerritoryMetadata.meta == null)
				{
					TerritoryMetadata.meta = new TerritoryMetadata();
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


				meta.AddTypeMap("Territoryid", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Territorydescription", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Regionid", new esTypeMap("int4", "System.Int32"));			
				
				
				
				meta.Source = "territory";
				meta.Destination = "territory";
				
				meta.spInsert = "proc_territoryInsert";				
				meta.spUpdate = "proc_territoryUpdate";		
				meta.spDelete = "proc_territoryDelete";
				meta.spLoadAll = "proc_territoryLoadAll";
				meta.spLoadByPrimaryKey = "proc_territoryLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private TerritoryMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
