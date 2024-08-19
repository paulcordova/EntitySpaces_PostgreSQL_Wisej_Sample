
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2024.3.0001.1
EntitySpaces Driver  : PostgreSQL
Date Generated       : 18-08-2024 17:47:33
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
	/// Encapsulates the 'employeeterritory' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(Employeeterritory))]	
	[XmlType("Employeeterritory")]
	public partial class Employeeterritory : esEmployeeterritory
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new Employeeterritory();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 employeeid, System.String territoryid)
		{
			var obj = new Employeeterritory();
			obj.Employeeid = employeeid;
			obj.Territoryid = territoryid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 employeeid, System.String territoryid, esSqlAccessType sqlAccessType)
		{
			var obj = new Employeeterritory();
			obj.Employeeid = employeeid;
			obj.Territoryid = territoryid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("EmployeeterritoryCollection")]
	public partial class EmployeeterritoryCollection : esEmployeeterritoryCollection, IEnumerable<Employeeterritory>
	{
		public Employeeterritory FindByPrimaryKey(System.Int32 employeeid, System.String territoryid)
		{
			return this.SingleOrDefault(e => e.Employeeid == employeeid && e.Territoryid == territoryid);
		}

		
				
	}



	[Serializable]	
	public partial class EmployeeterritoryQuery : esEmployeeterritoryQuery
	{
		public EmployeeterritoryQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public EmployeeterritoryQuery(string joinAlias, out EmployeeterritoryQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "EmployeeterritoryQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(EmployeeterritoryQuery query)
		{
			return EmployeeterritoryQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator EmployeeterritoryQuery(string query)
		{
			return (EmployeeterritoryQuery)EmployeeterritoryQuery.SerializeHelper.FromXml(query, typeof(EmployeeterritoryQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esEmployeeterritory : esEntity
	{
		public esEmployeeterritory()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 employeeid, System.String territoryid)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(employeeid, territoryid);
			else
				return LoadByPrimaryKeyStoredProcedure(employeeid, territoryid);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 employeeid, System.String territoryid)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(employeeid, territoryid);
			else
				return LoadByPrimaryKeyStoredProcedure(employeeid, territoryid);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 employeeid, System.String territoryid)
		{
			EmployeeterritoryQuery query = new EmployeeterritoryQuery();
			query.Where(query.Employeeid == employeeid, query.Territoryid == territoryid);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 employeeid, System.String territoryid)
		{
			esParameters parms = new esParameters();
			parms.Add("Employeeid", employeeid);			parms.Add("Territoryid", territoryid);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to employeeterritory.employeeid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Employeeid
		{
			get
			{
				return base.GetSystemInt32(EmployeeterritoryMetadata.ColumnNames.Employeeid);
			}
			
			set
			{
				if(base.SetSystemInt32(EmployeeterritoryMetadata.ColumnNames.Employeeid, value))
				{
					OnPropertyChanged(EmployeeterritoryMetadata.PropertyNames.Employeeid);
				}
			}
		}		
		
		/// <summary>
		/// Maps to employeeterritory.territoryid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Territoryid
		{
			get
			{
				return base.GetSystemString(EmployeeterritoryMetadata.ColumnNames.Territoryid);
			}
			
			set
			{
				if(base.SetSystemString(EmployeeterritoryMetadata.ColumnNames.Territoryid, value))
				{
					OnPropertyChanged(EmployeeterritoryMetadata.PropertyNames.Territoryid);
				}
			}
		}		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return EmployeeterritoryMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public EmployeeterritoryQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new EmployeeterritoryQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(EmployeeterritoryQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(EmployeeterritoryQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private EmployeeterritoryQuery query;		
	}



	[Serializable]
	abstract public partial class esEmployeeterritoryCollection : esEntityCollection<Employeeterritory>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return EmployeeterritoryMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "EmployeeterritoryCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public EmployeeterritoryQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new EmployeeterritoryQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(EmployeeterritoryQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new EmployeeterritoryQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(EmployeeterritoryQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((EmployeeterritoryQuery)query);
		}

		#endregion
		
		private EmployeeterritoryQuery query;
	}



	[Serializable]
	abstract public partial class esEmployeeterritoryQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return EmployeeterritoryMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Employeeid": return this.Employeeid;
				case "Territoryid": return this.Territoryid;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Employeeid
		{
			get { return new esQueryItem(this, EmployeeterritoryMetadata.ColumnNames.Employeeid, esSystemType.Int32); }
		} 
		
		public esQueryItem Territoryid
		{
			get { return new esQueryItem(this, EmployeeterritoryMetadata.ColumnNames.Territoryid, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class Employeeterritory : esEmployeeterritory
	{

		
		
	}
	



	[Serializable]
	public partial class EmployeeterritoryMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected EmployeeterritoryMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(EmployeeterritoryMetadata.ColumnNames.Employeeid, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = EmployeeterritoryMetadata.PropertyNames.Employeeid;
			c.IsInPrimaryKey = true;
			c.NumericPrecision = 32;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EmployeeterritoryMetadata.ColumnNames.Territoryid, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = EmployeeterritoryMetadata.PropertyNames.Territoryid;
			c.IsInPrimaryKey = true;
			c.CharacterMaxLength = 20;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public EmployeeterritoryMetadata Meta()
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
			 public const string Employeeid = "employeeid";
			 public const string Territoryid = "territoryid";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Employeeid = "Employeeid";
			 public const string Territoryid = "Territoryid";
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
			lock (typeof(EmployeeterritoryMetadata))
			{
				if(EmployeeterritoryMetadata.mapDelegates == null)
				{
					EmployeeterritoryMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (EmployeeterritoryMetadata.meta == null)
				{
					EmployeeterritoryMetadata.meta = new EmployeeterritoryMetadata();
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


				meta.AddTypeMap("Employeeid", new esTypeMap("int4", "System.Int32"));
				meta.AddTypeMap("Territoryid", new esTypeMap("varchar", "System.String"));			
				
				
				
				meta.Source = "employeeterritory";
				meta.Destination = "employeeterritory";
				
				meta.spInsert = "proc_employeeterritoryInsert";				
				meta.spUpdate = "proc_employeeterritoryUpdate";		
				meta.spDelete = "proc_employeeterritoryDelete";
				meta.spLoadAll = "proc_employeeterritoryLoadAll";
				meta.spLoadByPrimaryKey = "proc_employeeterritoryLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private EmployeeterritoryMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
