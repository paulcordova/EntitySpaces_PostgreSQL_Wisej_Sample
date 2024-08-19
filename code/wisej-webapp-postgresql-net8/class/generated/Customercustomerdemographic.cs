
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2024.3.0001.1
EntitySpaces Driver  : PostgreSQL
Date Generated       : 18-08-2024 17:47:28
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
	/// Encapsulates the 'customercustomerdemographic' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(Customercustomerdemographic))]	
	[XmlType("Customercustomerdemographic")]
	public partial class Customercustomerdemographic : esCustomercustomerdemographic
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new Customercustomerdemographic();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.String customerid, System.String customertypeid)
		{
			var obj = new Customercustomerdemographic();
			obj.Customerid = customerid;
			obj.Customertypeid = customertypeid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.String customerid, System.String customertypeid, esSqlAccessType sqlAccessType)
		{
			var obj = new Customercustomerdemographic();
			obj.Customerid = customerid;
			obj.Customertypeid = customertypeid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("CustomercustomerdemographicCollection")]
	public partial class CustomercustomerdemographicCollection : esCustomercustomerdemographicCollection, IEnumerable<Customercustomerdemographic>
	{
		public Customercustomerdemographic FindByPrimaryKey(System.String customerid, System.String customertypeid)
		{
			return this.SingleOrDefault(e => e.Customerid == customerid && e.Customertypeid == customertypeid);
		}

		
				
	}



	[Serializable]	
	public partial class CustomercustomerdemographicQuery : esCustomercustomerdemographicQuery
	{
		public CustomercustomerdemographicQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public CustomercustomerdemographicQuery(string joinAlias, out CustomercustomerdemographicQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "CustomercustomerdemographicQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(CustomercustomerdemographicQuery query)
		{
			return CustomercustomerdemographicQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator CustomercustomerdemographicQuery(string query)
		{
			return (CustomercustomerdemographicQuery)CustomercustomerdemographicQuery.SerializeHelper.FromXml(query, typeof(CustomercustomerdemographicQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esCustomercustomerdemographic : esEntity
	{
		public esCustomercustomerdemographic()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.String customerid, System.String customertypeid)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(customerid, customertypeid);
			else
				return LoadByPrimaryKeyStoredProcedure(customerid, customertypeid);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.String customerid, System.String customertypeid)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(customerid, customertypeid);
			else
				return LoadByPrimaryKeyStoredProcedure(customerid, customertypeid);
		}

		private bool LoadByPrimaryKeyDynamic(System.String customerid, System.String customertypeid)
		{
			CustomercustomerdemographicQuery query = new CustomercustomerdemographicQuery();
			query.Where(query.Customerid == customerid, query.Customertypeid == customertypeid);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.String customerid, System.String customertypeid)
		{
			esParameters parms = new esParameters();
			parms.Add("Customerid", customerid);			parms.Add("Customertypeid", customertypeid);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to customercustomerdemographic.customerid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Customerid
		{
			get
			{
				return base.GetSystemString(CustomercustomerdemographicMetadata.ColumnNames.Customerid);
			}
			
			set
			{
				if(base.SetSystemString(CustomercustomerdemographicMetadata.ColumnNames.Customerid, value))
				{
					OnPropertyChanged(CustomercustomerdemographicMetadata.PropertyNames.Customerid);
				}
			}
		}		
		
		/// <summary>
		/// Maps to customercustomerdemographic.customertypeid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Customertypeid
		{
			get
			{
				return base.GetSystemString(CustomercustomerdemographicMetadata.ColumnNames.Customertypeid);
			}
			
			set
			{
				if(base.SetSystemString(CustomercustomerdemographicMetadata.ColumnNames.Customertypeid, value))
				{
					OnPropertyChanged(CustomercustomerdemographicMetadata.PropertyNames.Customertypeid);
				}
			}
		}		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return CustomercustomerdemographicMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public CustomercustomerdemographicQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new CustomercustomerdemographicQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(CustomercustomerdemographicQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(CustomercustomerdemographicQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private CustomercustomerdemographicQuery query;		
	}



	[Serializable]
	abstract public partial class esCustomercustomerdemographicCollection : esEntityCollection<Customercustomerdemographic>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return CustomercustomerdemographicMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "CustomercustomerdemographicCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public CustomercustomerdemographicQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new CustomercustomerdemographicQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(CustomercustomerdemographicQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new CustomercustomerdemographicQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(CustomercustomerdemographicQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((CustomercustomerdemographicQuery)query);
		}

		#endregion
		
		private CustomercustomerdemographicQuery query;
	}



	[Serializable]
	abstract public partial class esCustomercustomerdemographicQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return CustomercustomerdemographicMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Customerid": return this.Customerid;
				case "Customertypeid": return this.Customertypeid;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Customerid
		{
			get { return new esQueryItem(this, CustomercustomerdemographicMetadata.ColumnNames.Customerid, esSystemType.String); }
		} 
		
		public esQueryItem Customertypeid
		{
			get { return new esQueryItem(this, CustomercustomerdemographicMetadata.ColumnNames.Customertypeid, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class Customercustomerdemographic : esCustomercustomerdemographic
	{

		
		
	}
	



	[Serializable]
	public partial class CustomercustomerdemographicMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected CustomercustomerdemographicMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(CustomercustomerdemographicMetadata.ColumnNames.Customerid, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomercustomerdemographicMetadata.PropertyNames.Customerid;
			c.IsInPrimaryKey = true;
			c.CharacterMaxLength = 5;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomercustomerdemographicMetadata.ColumnNames.Customertypeid, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomercustomerdemographicMetadata.PropertyNames.Customertypeid;
			c.IsInPrimaryKey = true;
			c.CharacterMaxLength = 10;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public CustomercustomerdemographicMetadata Meta()
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
			 public const string Customerid = "customerid";
			 public const string Customertypeid = "customertypeid";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Customerid = "Customerid";
			 public const string Customertypeid = "Customertypeid";
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
			lock (typeof(CustomercustomerdemographicMetadata))
			{
				if(CustomercustomerdemographicMetadata.mapDelegates == null)
				{
					CustomercustomerdemographicMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (CustomercustomerdemographicMetadata.meta == null)
				{
					CustomercustomerdemographicMetadata.meta = new CustomercustomerdemographicMetadata();
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


				meta.AddTypeMap("Customerid", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Customertypeid", new esTypeMap("varchar", "System.String"));			
				
				
				
				meta.Source = "customercustomerdemographic";
				meta.Destination = "customercustomerdemographic";
				
				meta.spInsert = "proc_customercustomerdemographicInsert";				
				meta.spUpdate = "proc_customercustomerdemographicUpdate";		
				meta.spDelete = "proc_customercustomerdemographicDelete";
				meta.spLoadAll = "proc_customercustomerdemographicLoadAll";
				meta.spLoadByPrimaryKey = "proc_customercustomerdemographicLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private CustomercustomerdemographicMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
