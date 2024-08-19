
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2024.3.0001.1
EntitySpaces Driver  : PostgreSQL
Date Generated       : 18-08-2024 17:47:26
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
	/// Encapsulates the 'category' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(Category))]	
	[XmlType("Category")]
	public partial class Category : esCategory
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new Category();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 categoryid)
		{
			var obj = new Category();
			obj.Categoryid = categoryid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 categoryid, esSqlAccessType sqlAccessType)
		{
			var obj = new Category();
			obj.Categoryid = categoryid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("CategoryCollection")]
	public partial class CategoryCollection : esCategoryCollection, IEnumerable<Category>
	{
		public Category FindByPrimaryKey(System.Int32 categoryid)
		{
			return this.SingleOrDefault(e => e.Categoryid == categoryid);
		}

		
				
	}



	[Serializable]	
	public partial class CategoryQuery : esCategoryQuery
	{
		public CategoryQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public CategoryQuery(string joinAlias, out CategoryQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "CategoryQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(CategoryQuery query)
		{
			return CategoryQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator CategoryQuery(string query)
		{
			return (CategoryQuery)CategoryQuery.SerializeHelper.FromXml(query, typeof(CategoryQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esCategory : esEntity
	{
		public esCategory()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 categoryid)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(categoryid);
			else
				return LoadByPrimaryKeyStoredProcedure(categoryid);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 categoryid)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(categoryid);
			else
				return LoadByPrimaryKeyStoredProcedure(categoryid);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 categoryid)
		{
			CategoryQuery query = new CategoryQuery();
			query.Where(query.Categoryid == categoryid);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 categoryid)
		{
			esParameters parms = new esParameters();
			parms.Add("Categoryid", categoryid);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to category.categoryid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Categoryid
		{
			get
			{
				return base.GetSystemInt32(CategoryMetadata.ColumnNames.Categoryid);
			}
			
			set
			{
				if(base.SetSystemInt32(CategoryMetadata.ColumnNames.Categoryid, value))
				{
					OnPropertyChanged(CategoryMetadata.PropertyNames.Categoryid);
				}
			}
		}		
		
		/// <summary>
		/// Maps to category.categoryname
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Categoryname
		{
			get
			{
				return base.GetSystemString(CategoryMetadata.ColumnNames.Categoryname);
			}
			
			set
			{
				if(base.SetSystemString(CategoryMetadata.ColumnNames.Categoryname, value))
				{
					OnPropertyChanged(CategoryMetadata.PropertyNames.Categoryname);
				}
			}
		}		
		
		/// <summary>
		/// Maps to category.description
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Description
		{
			get
			{
				return base.GetSystemString(CategoryMetadata.ColumnNames.Description);
			}
			
			set
			{
				if(base.SetSystemString(CategoryMetadata.ColumnNames.Description, value))
				{
					OnPropertyChanged(CategoryMetadata.PropertyNames.Description);
				}
			}
		}		
		
		/// <summary>
		/// Maps to category.picture
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Byte[] Picture
		{
			get
			{
				return base.GetSystemByteArray(CategoryMetadata.ColumnNames.Picture);
			}
			
			set
			{
				if(base.SetSystemByteArray(CategoryMetadata.ColumnNames.Picture, value))
				{
					OnPropertyChanged(CategoryMetadata.PropertyNames.Picture);
				}
			}
		}		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return CategoryMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public CategoryQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new CategoryQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(CategoryQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(CategoryQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private CategoryQuery query;		
	}



	[Serializable]
	abstract public partial class esCategoryCollection : esEntityCollection<Category>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return CategoryMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "CategoryCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public CategoryQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new CategoryQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(CategoryQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new CategoryQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(CategoryQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((CategoryQuery)query);
		}

		#endregion
		
		private CategoryQuery query;
	}



	[Serializable]
	abstract public partial class esCategoryQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return CategoryMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Categoryid": return this.Categoryid;
				case "Categoryname": return this.Categoryname;
				case "Description": return this.Description;
				case "Picture": return this.Picture;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Categoryid
		{
			get { return new esQueryItem(this, CategoryMetadata.ColumnNames.Categoryid, esSystemType.Int32); }
		} 
		
		public esQueryItem Categoryname
		{
			get { return new esQueryItem(this, CategoryMetadata.ColumnNames.Categoryname, esSystemType.String); }
		} 
		
		public esQueryItem Description
		{
			get { return new esQueryItem(this, CategoryMetadata.ColumnNames.Description, esSystemType.String); }
		} 
		
		public esQueryItem Picture
		{
			get { return new esQueryItem(this, CategoryMetadata.ColumnNames.Picture, esSystemType.ByteArray); }
		} 
		
		#endregion
		
	}


	
	public partial class Category : esCategory
	{

		
		
	}
	



	[Serializable]
	public partial class CategoryMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected CategoryMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(CategoryMetadata.ColumnNames.Categoryid, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = CategoryMetadata.PropertyNames.Categoryid;
			c.IsInPrimaryKey = true;
			c.NumericPrecision = 32;
			c.HasDefault = true;
			c.Default = @"nextval('category_categoryid_seq'::regclass)";
			m_columns.Add(c);
				
			c = new esColumnMetadata(CategoryMetadata.ColumnNames.Categoryname, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = CategoryMetadata.PropertyNames.Categoryname;
			c.CharacterMaxLength = 15;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CategoryMetadata.ColumnNames.Description, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = CategoryMetadata.PropertyNames.Description;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CategoryMetadata.ColumnNames.Picture, 3, typeof(System.Byte[]), esSystemType.ByteArray);
			c.PropertyName = CategoryMetadata.PropertyNames.Picture;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public CategoryMetadata Meta()
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
			 public const string Categoryid = "categoryid";
			 public const string Categoryname = "categoryname";
			 public const string Description = "description";
			 public const string Picture = "picture";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Categoryid = "Categoryid";
			 public const string Categoryname = "Categoryname";
			 public const string Description = "Description";
			 public const string Picture = "Picture";
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
			lock (typeof(CategoryMetadata))
			{
				if(CategoryMetadata.mapDelegates == null)
				{
					CategoryMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (CategoryMetadata.meta == null)
				{
					CategoryMetadata.meta = new CategoryMetadata();
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


				meta.AddTypeMap("Categoryid", new esTypeMap("int4", "System.Int32"));
				meta.AddTypeMap("Categoryname", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Description", new esTypeMap("text", "System.String"));
				meta.AddTypeMap("Picture", new esTypeMap("bytea", "System.Byte[]"));			
				
				
				
				meta.Source = "category";
				meta.Destination = "category";
				
				meta.spInsert = "proc_categoryInsert";				
				meta.spUpdate = "proc_categoryUpdate";		
				meta.spDelete = "proc_categoryDelete";
				meta.spLoadAll = "proc_categoryLoadAll";
				meta.spLoadByPrimaryKey = "proc_categoryLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private CategoryMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
