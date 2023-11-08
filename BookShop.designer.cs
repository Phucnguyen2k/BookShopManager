﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookShopManager
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="BOOKSHOPSDB")]
	public partial class BookShopDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertBillTbl(BillTbl instance);
    partial void UpdateBillTbl(BillTbl instance);
    partial void DeleteBillTbl(BillTbl instance);
    partial void InsertUserTbl(UserTbl instance);
    partial void UpdateUserTbl(UserTbl instance);
    partial void DeleteUserTbl(UserTbl instance);
    partial void InsertBookTbl(BookTbl instance);
    partial void UpdateBookTbl(BookTbl instance);
    partial void DeleteBookTbl(BookTbl instance);
    #endregion
		
		public BookShopDataContext() : 
				base(global::BookShopManager.Properties.Settings.Default.BOOKSHOPSDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public BookShopDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BookShopDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BookShopDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BookShopDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<BillTbl> BillTbls
		{
			get
			{
				return this.GetTable<BillTbl>();
			}
		}
		
		public System.Data.Linq.Table<UserTbl> UserTbls
		{
			get
			{
				return this.GetTable<UserTbl>();
			}
		}
		
		public System.Data.Linq.Table<BookTbl> BookTbls
		{
			get
			{
				return this.GetTable<BookTbl>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BillTbl")]
	public partial class BillTbl : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _BillId;
		
		private string _UName;
		
		private string _ClineName;
		
		private int _Amount;
		
		private System.Nullable<System.DateTime> _UDate;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnBillIdChanging(int value);
    partial void OnBillIdChanged();
    partial void OnUNameChanging(string value);
    partial void OnUNameChanged();
    partial void OnClineNameChanging(string value);
    partial void OnClineNameChanged();
    partial void OnAmountChanging(int value);
    partial void OnAmountChanged();
    partial void OnUDateChanging(System.Nullable<System.DateTime> value);
    partial void OnUDateChanged();
    #endregion
		
		public BillTbl()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BillId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int BillId
		{
			get
			{
				return this._BillId;
			}
			set
			{
				if ((this._BillId != value))
				{
					this.OnBillIdChanging(value);
					this.SendPropertyChanging();
					this._BillId = value;
					this.SendPropertyChanged("BillId");
					this.OnBillIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UName", DbType="NChar(50) NOT NULL", CanBeNull=false)]
		public string UName
		{
			get
			{
				return this._UName;
			}
			set
			{
				if ((this._UName != value))
				{
					this.OnUNameChanging(value);
					this.SendPropertyChanging();
					this._UName = value;
					this.SendPropertyChanged("UName");
					this.OnUNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ClineName", DbType="NChar(50) NOT NULL", CanBeNull=false)]
		public string ClineName
		{
			get
			{
				return this._ClineName;
			}
			set
			{
				if ((this._ClineName != value))
				{
					this.OnClineNameChanging(value);
					this.SendPropertyChanging();
					this._ClineName = value;
					this.SendPropertyChanged("ClineName");
					this.OnClineNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Amount", DbType="Int NOT NULL")]
		public int Amount
		{
			get
			{
				return this._Amount;
			}
			set
			{
				if ((this._Amount != value))
				{
					this.OnAmountChanging(value);
					this.SendPropertyChanging();
					this._Amount = value;
					this.SendPropertyChanged("Amount");
					this.OnAmountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UDate", DbType="Date")]
		public System.Nullable<System.DateTime> UDate
		{
			get
			{
				return this._UDate;
			}
			set
			{
				if ((this._UDate != value))
				{
					this.OnUDateChanging(value);
					this.SendPropertyChanging();
					this._UDate = value;
					this.SendPropertyChanged("UDate");
					this.OnUDateChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.UserTbl")]
	public partial class UserTbl : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _UId;
		
		private string _UName;
		
		private string _UPhone;
		
		private string _UAdd;
		
		private string _UPass;
		
		private System.Nullable<System.DateTime> _UYob;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUIdChanging(int value);
    partial void OnUIdChanged();
    partial void OnUNameChanging(string value);
    partial void OnUNameChanged();
    partial void OnUPhoneChanging(string value);
    partial void OnUPhoneChanged();
    partial void OnUAddChanging(string value);
    partial void OnUAddChanged();
    partial void OnUPassChanging(string value);
    partial void OnUPassChanged();
    partial void OnUYobChanging(System.Nullable<System.DateTime> value);
    partial void OnUYobChanged();
    #endregion
		
		public UserTbl()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int UId
		{
			get
			{
				return this._UId;
			}
			set
			{
				if ((this._UId != value))
				{
					this.OnUIdChanging(value);
					this.SendPropertyChanging();
					this._UId = value;
					this.SendPropertyChanged("UId");
					this.OnUIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UName", DbType="NChar(20) NOT NULL", CanBeNull=false)]
		public string UName
		{
			get
			{
				return this._UName;
			}
			set
			{
				if ((this._UName != value))
				{
					this.OnUNameChanging(value);
					this.SendPropertyChanging();
					this._UName = value;
					this.SendPropertyChanged("UName");
					this.OnUNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UPhone", DbType="NChar(12) NOT NULL", CanBeNull=false)]
		public string UPhone
		{
			get
			{
				return this._UPhone;
			}
			set
			{
				if ((this._UPhone != value))
				{
					this.OnUPhoneChanging(value);
					this.SendPropertyChanging();
					this._UPhone = value;
					this.SendPropertyChanged("UPhone");
					this.OnUPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UAdd", DbType="NChar(12) NOT NULL", CanBeNull=false)]
		public string UAdd
		{
			get
			{
				return this._UAdd;
			}
			set
			{
				if ((this._UAdd != value))
				{
					this.OnUAddChanging(value);
					this.SendPropertyChanging();
					this._UAdd = value;
					this.SendPropertyChanged("UAdd");
					this.OnUAddChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UPass", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string UPass
		{
			get
			{
				return this._UPass;
			}
			set
			{
				if ((this._UPass != value))
				{
					this.OnUPassChanging(value);
					this.SendPropertyChanging();
					this._UPass = value;
					this.SendPropertyChanged("UPass");
					this.OnUPassChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UYob", DbType="Date")]
		public System.Nullable<System.DateTime> UYob
		{
			get
			{
				return this._UYob;
			}
			set
			{
				if ((this._UYob != value))
				{
					this.OnUYobChanging(value);
					this.SendPropertyChanging();
					this._UYob = value;
					this.SendPropertyChanged("UYob");
					this.OnUYobChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BookTbl")]
	public partial class BookTbl : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _BId;
		
		private string _BTitle;
		
		private string _BAuthor;
		
		private string _BCat;
		
		private int _BQty;
		
		private int _BPrice;
		
		private System.Nullable<int> _BYear;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnBIdChanging(int value);
    partial void OnBIdChanged();
    partial void OnBTitleChanging(string value);
    partial void OnBTitleChanged();
    partial void OnBAuthorChanging(string value);
    partial void OnBAuthorChanged();
    partial void OnBCatChanging(string value);
    partial void OnBCatChanged();
    partial void OnBQtyChanging(int value);
    partial void OnBQtyChanged();
    partial void OnBPriceChanging(int value);
    partial void OnBPriceChanged();
    partial void OnBYearChanging(System.Nullable<int> value);
    partial void OnBYearChanged();
    #endregion
		
		public BookTbl()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int BId
		{
			get
			{
				return this._BId;
			}
			set
			{
				if ((this._BId != value))
				{
					this.OnBIdChanging(value);
					this.SendPropertyChanging();
					this._BId = value;
					this.SendPropertyChanged("BId");
					this.OnBIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BTitle", DbType="NChar(30) NOT NULL", CanBeNull=false)]
		public string BTitle
		{
			get
			{
				return this._BTitle;
			}
			set
			{
				if ((this._BTitle != value))
				{
					this.OnBTitleChanging(value);
					this.SendPropertyChanging();
					this._BTitle = value;
					this.SendPropertyChanged("BTitle");
					this.OnBTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BAuthor", DbType="NChar(15) NOT NULL", CanBeNull=false)]
		public string BAuthor
		{
			get
			{
				return this._BAuthor;
			}
			set
			{
				if ((this._BAuthor != value))
				{
					this.OnBAuthorChanging(value);
					this.SendPropertyChanging();
					this._BAuthor = value;
					this.SendPropertyChanged("BAuthor");
					this.OnBAuthorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BCat", DbType="NChar(15) NOT NULL", CanBeNull=false)]
		public string BCat
		{
			get
			{
				return this._BCat;
			}
			set
			{
				if ((this._BCat != value))
				{
					this.OnBCatChanging(value);
					this.SendPropertyChanging();
					this._BCat = value;
					this.SendPropertyChanged("BCat");
					this.OnBCatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BQty", DbType="Int NOT NULL")]
		public int BQty
		{
			get
			{
				return this._BQty;
			}
			set
			{
				if ((this._BQty != value))
				{
					this.OnBQtyChanging(value);
					this.SendPropertyChanging();
					this._BQty = value;
					this.SendPropertyChanged("BQty");
					this.OnBQtyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BPrice", DbType="Int NOT NULL")]
		public int BPrice
		{
			get
			{
				return this._BPrice;
			}
			set
			{
				if ((this._BPrice != value))
				{
					this.OnBPriceChanging(value);
					this.SendPropertyChanging();
					this._BPrice = value;
					this.SendPropertyChanged("BPrice");
					this.OnBPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BYear", DbType="Int")]
		public System.Nullable<int> BYear
		{
			get
			{
				return this._BYear;
			}
			set
			{
				if ((this._BYear != value))
				{
					this.OnBYearChanging(value);
					this.SendPropertyChanging();
					this._BYear = value;
					this.SendPropertyChanged("BYear");
					this.OnBYearChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591