
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2024.3.0001.1
EntitySpaces Driver  : PostgreSQL
Date Generated       : 18-08-2024 17:47:30
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
	/// Encapsulates the 'customerdemographic' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(Customerdemographic))]	
	[XmlType("Customerdemographic")]
	public partial class Customerdemographic : esCustomerdemographic
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new Customerdemographic();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.String customertypeid)
		{
			var obj = new Customerdemographic();
			obj.Customertypeid = customertypeid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.String customertypeid, esSqlAccessType sqlAccessType)
		{
			var obj = new Customerdemographic();
			obj.Customertypeid = customertypeid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("CustomerdemographicCollection")]
	public partial class CustomerdemographicCollection : esCustomerdemographicCollection, IEnumerable<Customerdemographic>
	{
		public Customerdemographic FindByPrimaryKey(System.String customertypeid)
		{
			return this.SingleOrDefault(e => e.Customertypeid == customertypeid);
		}

		
				
	}



	[Serializable]	
	public partial class CustomerdemographicQuery : esCustomerdemographicQuery
	{
		public CustomerdemographicQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public CustomerdemographicQuery(string joinAlias, out CustomerdemographicQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "CustomerdemographicQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(CustomerdemographicQuery query)
		{
			return CustomerdemographicQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator CustomerdemographicQuery(string query)
		{
			return (CustomerdemographicQuery)CustomerdemographicQuery.SerializeHelper.FromXml(query, typeof(CustomerdemographicQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esCustomerdemographic : esEntity
	{
		public esCustomerdemographic()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.String customertypeid)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(customertypeid);
			else
				return LoadByPrimaryKeyStoredProcedure(customertypeid);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.String customertypeid)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(customertypeid);
			else
				return LoadByPrimaryKeyStoredProcedure(customertypeid);
		}

		private bool LoadByPrimaryKeyDynamic(System.String customertypeid)
		{
			CustomerdemographicQuery query = new CustomerdemographicQuery();
			query.Where(query.Customertypeid == customertypeid);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.String customertypeid)
		{
			esParameters parms = new esParameters();
			parms.Add("Customertypeid", customertypeid);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to customerdemographic.customertypeid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Customertypeid
		{
			get
			{
				return base.GetSystemString(CustomerdemographicMetadata.ColumnNames.Customertypeid);
			}
			
			set
			{
				if(base.SetSystemString(CustomerdemographicMetadata.ColumnNames.Customertypeid, value))
				{
					OnPropertyChanged(CustomerdemographicMetadata.PropertyNames.Customertypeid);
				}
			}
		}		
		
		/// <summary>
		/// Maps to customerdemographic.customerdesc
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Customerdesc
		{
			get
			{
				return base.GetSystemString(CustomerdemographicMetadata.ColumnNames.Customerdesc);
			}
			
			set
			{
				if(base.SetSystemString(CustomerdemographicMetadata.ColumnNames.Customerdesc, value))
				{
					OnPropertyChanged(CustomerdemographicMetadata.PropertyNames.Customerdesc);
				}
			}
		}		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return CustomerdemographicMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public CustomerdemographicQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new CustomerdemographicQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(CustomerdemographicQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(CustomerdemographicQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private CustomerdemographicQuery query;		
	}



	[Serializable]
	abstract public partial class esCustomerdemographicCollection : esEntityCollection<Customerdemographic>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return CustomerdemographicMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "CustomerdemographicCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public CustomerdemographicQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new CustomerdemographicQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(CustomerdemographicQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new CustomerdemographicQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(CustomerdemographicQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((CustomerdemographicQuery)query);
		}

		#endregion
		
		private CustomerdemographicQuery query;
	}



	[Serializable]
	abstract public partial class esCustomerdemographicQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return CustomerdemographicMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Customertypeid": return this.Customertypeid;
				case "Customerdesc": return this.Customerdesc;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Customertypeid
		{
			get { return new esQueryItem(this, CustomerdemographicMetadata.ColumnNames.Customertypeid, esSystemType.String); }
		} 
		
		public esQueryItem Customerdesc
		{
			get { return new esQueryItem(this, CustomerdemographicMetadata.ColumnNames.Customerdesc, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class Customerdemographic : esCustomerdemographic
	{

		
		
	}
	



	[Serializable]
	public partial class CustomerdemographicMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected CustomerdemographicMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(CustomerdemographicMetadata.ColumnNames.Customertypeid, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomerdemographicMetadata.PropertyNames.Customertypeid;
			c.IsInPrimaryKey = true;
			c.CharacterMaxLength = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomerdemographicMetadata.ColumnNames.Customerdesc, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomerdemographicMetadata.PropertyNames.Customerdesc;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public CustomerdemographicMetadata Meta()
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
			 public const string Customertypeid = "customertypeid";
			 public const string Customerdesc = "customerdesc";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Customertypeid = "Customertypeid";
			 public const string Customerdesc = "Customerdesc";
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
			lock (typeof(CustomerdemographicMetadata))
			{
				if(CustomerdemographicMetadata.mapDelegates == null)
				{
					CustomerdemographicMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (CustomerdemographicMetadata.meta == null)
				{
					CustomerdemographicMetadata.meta = new CustomerdemographicMetadata();
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


				meta.AddTypeMap("Customertypeid", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Customerdesc", new esTypeMap("text", "System.String"));			
				
				
				
				meta.Source = "customerdemographic";
				meta.Destination = "customerdemographic";
				
				meta.spInsert = "proc_customerdemographicInsert";				
				meta.spUpdate = "proc_customerdemographicUpdate";		
				meta.spDelete = "proc_customerdemographicDelete";
				meta.spLoadAll = "proc_customerdemographicLoadAll";
				meta.spLoadByPrimaryKey = "proc_customerdemographicLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private CustomerdemographicMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
