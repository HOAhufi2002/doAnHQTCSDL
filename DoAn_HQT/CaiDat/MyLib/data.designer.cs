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

namespace MyLib
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QLCF_TTHQT")]
	public partial class dataDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertBAN(BAN instance);
    partial void UpdateBAN(BAN instance);
    partial void DeleteBAN(BAN instance);
    partial void InsertNHANVIEN(NHANVIEN instance);
    partial void UpdateNHANVIEN(NHANVIEN instance);
    partial void DeleteNHANVIEN(NHANVIEN instance);
    partial void InsertCHITIETHD(CHITIETHD instance);
    partial void UpdateCHITIETHD(CHITIETHD instance);
    partial void DeleteCHITIETHD(CHITIETHD instance);
    partial void InsertHOADON(HOADON instance);
    partial void UpdateHOADON(HOADON instance);
    partial void DeleteHOADON(HOADON instance);
    partial void InsertLOAI(LOAI instance);
    partial void UpdateLOAI(LOAI instance);
    partial void DeleteLOAI(LOAI instance);
    partial void InsertSANPHAM(SANPHAM instance);
    partial void UpdateSANPHAM(SANPHAM instance);
    partial void DeleteSANPHAM(SANPHAM instance);
    #endregion
		
		public dataDataContext() : 
				base(global::MyLib.Properties.Settings.Default.QLCF_TTHQTConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public dataDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dataDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dataDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dataDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<BAN> BANs
		{
			get
			{
				return this.GetTable<BAN>();
			}
		}
		
		public System.Data.Linq.Table<NHANVIEN> NHANVIENs
		{
			get
			{
				return this.GetTable<NHANVIEN>();
			}
		}
		
		public System.Data.Linq.Table<CHITIETHD> CHITIETHDs
		{
			get
			{
				return this.GetTable<CHITIETHD>();
			}
		}
		
		public System.Data.Linq.Table<HOADON> HOADONs
		{
			get
			{
				return this.GetTable<HOADON>();
			}
		}
		
		public System.Data.Linq.Table<LOAI> LOAIs
		{
			get
			{
				return this.GetTable<LOAI>();
			}
		}
		
		public System.Data.Linq.Table<SANPHAM> SANPHAMs
		{
			get
			{
				return this.GetTable<SANPHAM>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BAN")]
	public partial class BAN : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MABAN;
		
		private System.Nullable<int> _SOBAN;
		
		private EntitySet<HOADON> _HOADONs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMABANChanging(string value);
    partial void OnMABANChanged();
    partial void OnSOBANChanging(System.Nullable<int> value);
    partial void OnSOBANChanged();
    #endregion
		
		public BAN()
		{
			this._HOADONs = new EntitySet<HOADON>(new Action<HOADON>(this.attach_HOADONs), new Action<HOADON>(this.detach_HOADONs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MABAN", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MABAN
		{
			get
			{
				return this._MABAN;
			}
			set
			{
				if ((this._MABAN != value))
				{
					this.OnMABANChanging(value);
					this.SendPropertyChanging();
					this._MABAN = value;
					this.SendPropertyChanged("MABAN");
					this.OnMABANChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SOBAN", DbType="Int")]
		public System.Nullable<int> SOBAN
		{
			get
			{
				return this._SOBAN;
			}
			set
			{
				if ((this._SOBAN != value))
				{
					this.OnSOBANChanging(value);
					this.SendPropertyChanging();
					this._SOBAN = value;
					this.SendPropertyChanged("SOBAN");
					this.OnSOBANChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="BAN_HOADON", Storage="_HOADONs", ThisKey="MABAN", OtherKey="MABAN")]
		public EntitySet<HOADON> HOADONs
		{
			get
			{
				return this._HOADONs;
			}
			set
			{
				this._HOADONs.Assign(value);
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
		
		private void attach_HOADONs(HOADON entity)
		{
			this.SendPropertyChanging();
			entity.BAN = this;
		}
		
		private void detach_HOADONs(HOADON entity)
		{
			this.SendPropertyChanging();
			entity.BAN = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NHANVIEN")]
	public partial class NHANVIEN : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MANV;
		
		private string _TENNV;
		
		private string _DIACHI;
		
		private string _GIOITINH;
		
		private System.Nullable<System.DateTime> _NGAYSINH;
		
		private string _SDT;
		
		private string _CHUCVU;
		
		private EntitySet<HOADON> _HOADONs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMANVChanging(string value);
    partial void OnMANVChanged();
    partial void OnTENNVChanging(string value);
    partial void OnTENNVChanged();
    partial void OnDIACHIChanging(string value);
    partial void OnDIACHIChanged();
    partial void OnGIOITINHChanging(string value);
    partial void OnGIOITINHChanged();
    partial void OnNGAYSINHChanging(System.Nullable<System.DateTime> value);
    partial void OnNGAYSINHChanged();
    partial void OnSDTChanging(string value);
    partial void OnSDTChanged();
    partial void OnCHUCVUChanging(string value);
    partial void OnCHUCVUChanged();
    #endregion
		
		public NHANVIEN()
		{
			this._HOADONs = new EntitySet<HOADON>(new Action<HOADON>(this.attach_HOADONs), new Action<HOADON>(this.detach_HOADONs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MANV", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MANV
		{
			get
			{
				return this._MANV;
			}
			set
			{
				if ((this._MANV != value))
				{
					this.OnMANVChanging(value);
					this.SendPropertyChanging();
					this._MANV = value;
					this.SendPropertyChanged("MANV");
					this.OnMANVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENNV", DbType="NVarChar(50)")]
		public string TENNV
		{
			get
			{
				return this._TENNV;
			}
			set
			{
				if ((this._TENNV != value))
				{
					this.OnTENNVChanging(value);
					this.SendPropertyChanging();
					this._TENNV = value;
					this.SendPropertyChanged("TENNV");
					this.OnTENNVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DIACHI", DbType="NVarChar(50)")]
		public string DIACHI
		{
			get
			{
				return this._DIACHI;
			}
			set
			{
				if ((this._DIACHI != value))
				{
					this.OnDIACHIChanging(value);
					this.SendPropertyChanging();
					this._DIACHI = value;
					this.SendPropertyChanged("DIACHI");
					this.OnDIACHIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GIOITINH", DbType="NVarChar(5)")]
		public string GIOITINH
		{
			get
			{
				return this._GIOITINH;
			}
			set
			{
				if ((this._GIOITINH != value))
				{
					this.OnGIOITINHChanging(value);
					this.SendPropertyChanging();
					this._GIOITINH = value;
					this.SendPropertyChanged("GIOITINH");
					this.OnGIOITINHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NGAYSINH", DbType="Date")]
		public System.Nullable<System.DateTime> NGAYSINH
		{
			get
			{
				return this._NGAYSINH;
			}
			set
			{
				if ((this._NGAYSINH != value))
				{
					this.OnNGAYSINHChanging(value);
					this.SendPropertyChanging();
					this._NGAYSINH = value;
					this.SendPropertyChanged("NGAYSINH");
					this.OnNGAYSINHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDT", DbType="VarChar(10)")]
		public string SDT
		{
			get
			{
				return this._SDT;
			}
			set
			{
				if ((this._SDT != value))
				{
					this.OnSDTChanging(value);
					this.SendPropertyChanging();
					this._SDT = value;
					this.SendPropertyChanged("SDT");
					this.OnSDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CHUCVU", DbType="NVarChar(30)")]
		public string CHUCVU
		{
			get
			{
				return this._CHUCVU;
			}
			set
			{
				if ((this._CHUCVU != value))
				{
					this.OnCHUCVUChanging(value);
					this.SendPropertyChanging();
					this._CHUCVU = value;
					this.SendPropertyChanged("CHUCVU");
					this.OnCHUCVUChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NHANVIEN_HOADON", Storage="_HOADONs", ThisKey="MANV", OtherKey="MANV")]
		public EntitySet<HOADON> HOADONs
		{
			get
			{
				return this._HOADONs;
			}
			set
			{
				this._HOADONs.Assign(value);
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
		
		private void attach_HOADONs(HOADON entity)
		{
			this.SendPropertyChanging();
			entity.NHANVIEN = this;
		}
		
		private void detach_HOADONs(HOADON entity)
		{
			this.SendPropertyChanging();
			entity.NHANVIEN = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CHITIETHD")]
	public partial class CHITIETHD : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MAHD;
		
		private string _MASP;
		
		private System.Nullable<double> _THANHTIEN;
		
		private System.Nullable<int> _SL;
		
		private EntityRef<HOADON> _HOADON;
		
		private EntityRef<SANPHAM> _SANPHAM;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMAHDChanging(string value);
    partial void OnMAHDChanged();
    partial void OnMASPChanging(string value);
    partial void OnMASPChanged();
    partial void OnTHANHTIENChanging(System.Nullable<double> value);
    partial void OnTHANHTIENChanged();
    partial void OnSLChanging(System.Nullable<int> value);
    partial void OnSLChanged();
    #endregion
		
		public CHITIETHD()
		{
			this._HOADON = default(EntityRef<HOADON>);
			this._SANPHAM = default(EntityRef<SANPHAM>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MAHD", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MAHD
		{
			get
			{
				return this._MAHD;
			}
			set
			{
				if ((this._MAHD != value))
				{
					if (this._HOADON.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMAHDChanging(value);
					this.SendPropertyChanging();
					this._MAHD = value;
					this.SendPropertyChanged("MAHD");
					this.OnMAHDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MASP", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MASP
		{
			get
			{
				return this._MASP;
			}
			set
			{
				if ((this._MASP != value))
				{
					if (this._SANPHAM.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMASPChanging(value);
					this.SendPropertyChanging();
					this._MASP = value;
					this.SendPropertyChanged("MASP");
					this.OnMASPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_THANHTIEN", DbType="Float")]
		public System.Nullable<double> THANHTIEN
		{
			get
			{
				return this._THANHTIEN;
			}
			set
			{
				if ((this._THANHTIEN != value))
				{
					this.OnTHANHTIENChanging(value);
					this.SendPropertyChanging();
					this._THANHTIEN = value;
					this.SendPropertyChanged("THANHTIEN");
					this.OnTHANHTIENChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SL", DbType="Int")]
		public System.Nullable<int> SL
		{
			get
			{
				return this._SL;
			}
			set
			{
				if ((this._SL != value))
				{
					this.OnSLChanging(value);
					this.SendPropertyChanging();
					this._SL = value;
					this.SendPropertyChanged("SL");
					this.OnSLChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="HOADON_CHITIETHD", Storage="_HOADON", ThisKey="MAHD", OtherKey="MAHD", IsForeignKey=true)]
		public HOADON HOADON
		{
			get
			{
				return this._HOADON.Entity;
			}
			set
			{
				HOADON previousValue = this._HOADON.Entity;
				if (((previousValue != value) 
							|| (this._HOADON.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._HOADON.Entity = null;
						previousValue.CHITIETHDs.Remove(this);
					}
					this._HOADON.Entity = value;
					if ((value != null))
					{
						value.CHITIETHDs.Add(this);
						this._MAHD = value.MAHD;
					}
					else
					{
						this._MAHD = default(string);
					}
					this.SendPropertyChanged("HOADON");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SANPHAM_CHITIETHD", Storage="_SANPHAM", ThisKey="MASP", OtherKey="MASP", IsForeignKey=true)]
		public SANPHAM SANPHAM
		{
			get
			{
				return this._SANPHAM.Entity;
			}
			set
			{
				SANPHAM previousValue = this._SANPHAM.Entity;
				if (((previousValue != value) 
							|| (this._SANPHAM.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._SANPHAM.Entity = null;
						previousValue.CHITIETHDs.Remove(this);
					}
					this._SANPHAM.Entity = value;
					if ((value != null))
					{
						value.CHITIETHDs.Add(this);
						this._MASP = value.MASP;
					}
					else
					{
						this._MASP = default(string);
					}
					this.SendPropertyChanged("SANPHAM");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HOADON")]
	public partial class HOADON : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MAHD;
		
		private string _MANV;
		
		private string _MABAN;
		
		private System.Nullable<System.DateTime> _NGAYBAN;
		
		private System.Nullable<double> _TONGTIEN;
		
		private EntitySet<CHITIETHD> _CHITIETHDs;
		
		private EntityRef<BAN> _BAN;
		
		private EntityRef<NHANVIEN> _NHANVIEN;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMAHDChanging(string value);
    partial void OnMAHDChanged();
    partial void OnMANVChanging(string value);
    partial void OnMANVChanged();
    partial void OnMABANChanging(string value);
    partial void OnMABANChanged();
    partial void OnNGAYBANChanging(System.Nullable<System.DateTime> value);
    partial void OnNGAYBANChanged();
    partial void OnTONGTIENChanging(System.Nullable<double> value);
    partial void OnTONGTIENChanged();
    #endregion
		
		public HOADON()
		{
			this._CHITIETHDs = new EntitySet<CHITIETHD>(new Action<CHITIETHD>(this.attach_CHITIETHDs), new Action<CHITIETHD>(this.detach_CHITIETHDs));
			this._BAN = default(EntityRef<BAN>);
			this._NHANVIEN = default(EntityRef<NHANVIEN>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MAHD", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MAHD
		{
			get
			{
				return this._MAHD;
			}
			set
			{
				if ((this._MAHD != value))
				{
					this.OnMAHDChanging(value);
					this.SendPropertyChanging();
					this._MAHD = value;
					this.SendPropertyChanged("MAHD");
					this.OnMAHDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MANV", DbType="VarChar(10)")]
		public string MANV
		{
			get
			{
				return this._MANV;
			}
			set
			{
				if ((this._MANV != value))
				{
					if (this._NHANVIEN.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMANVChanging(value);
					this.SendPropertyChanging();
					this._MANV = value;
					this.SendPropertyChanged("MANV");
					this.OnMANVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MABAN", DbType="VarChar(10)")]
		public string MABAN
		{
			get
			{
				return this._MABAN;
			}
			set
			{
				if ((this._MABAN != value))
				{
					if (this._BAN.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMABANChanging(value);
					this.SendPropertyChanging();
					this._MABAN = value;
					this.SendPropertyChanged("MABAN");
					this.OnMABANChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NGAYBAN", DbType="Date")]
		public System.Nullable<System.DateTime> NGAYBAN
		{
			get
			{
				return this._NGAYBAN;
			}
			set
			{
				if ((this._NGAYBAN != value))
				{
					this.OnNGAYBANChanging(value);
					this.SendPropertyChanging();
					this._NGAYBAN = value;
					this.SendPropertyChanged("NGAYBAN");
					this.OnNGAYBANChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TONGTIEN", DbType="Float")]
		public System.Nullable<double> TONGTIEN
		{
			get
			{
				return this._TONGTIEN;
			}
			set
			{
				if ((this._TONGTIEN != value))
				{
					this.OnTONGTIENChanging(value);
					this.SendPropertyChanging();
					this._TONGTIEN = value;
					this.SendPropertyChanged("TONGTIEN");
					this.OnTONGTIENChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="HOADON_CHITIETHD", Storage="_CHITIETHDs", ThisKey="MAHD", OtherKey="MAHD")]
		public EntitySet<CHITIETHD> CHITIETHDs
		{
			get
			{
				return this._CHITIETHDs;
			}
			set
			{
				this._CHITIETHDs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="BAN_HOADON", Storage="_BAN", ThisKey="MABAN", OtherKey="MABAN", IsForeignKey=true)]
		public BAN BAN
		{
			get
			{
				return this._BAN.Entity;
			}
			set
			{
				BAN previousValue = this._BAN.Entity;
				if (((previousValue != value) 
							|| (this._BAN.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._BAN.Entity = null;
						previousValue.HOADONs.Remove(this);
					}
					this._BAN.Entity = value;
					if ((value != null))
					{
						value.HOADONs.Add(this);
						this._MABAN = value.MABAN;
					}
					else
					{
						this._MABAN = default(string);
					}
					this.SendPropertyChanged("BAN");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NHANVIEN_HOADON", Storage="_NHANVIEN", ThisKey="MANV", OtherKey="MANV", IsForeignKey=true)]
		public NHANVIEN NHANVIEN
		{
			get
			{
				return this._NHANVIEN.Entity;
			}
			set
			{
				NHANVIEN previousValue = this._NHANVIEN.Entity;
				if (((previousValue != value) 
							|| (this._NHANVIEN.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._NHANVIEN.Entity = null;
						previousValue.HOADONs.Remove(this);
					}
					this._NHANVIEN.Entity = value;
					if ((value != null))
					{
						value.HOADONs.Add(this);
						this._MANV = value.MANV;
					}
					else
					{
						this._MANV = default(string);
					}
					this.SendPropertyChanged("NHANVIEN");
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
		
		private void attach_CHITIETHDs(CHITIETHD entity)
		{
			this.SendPropertyChanging();
			entity.HOADON = this;
		}
		
		private void detach_CHITIETHDs(CHITIETHD entity)
		{
			this.SendPropertyChanging();
			entity.HOADON = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LOAI")]
	public partial class LOAI : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MALOAI;
		
		private string _TENLOAI;
		
		private EntitySet<SANPHAM> _SANPHAMs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMALOAIChanging(string value);
    partial void OnMALOAIChanged();
    partial void OnTENLOAIChanging(string value);
    partial void OnTENLOAIChanged();
    #endregion
		
		public LOAI()
		{
			this._SANPHAMs = new EntitySet<SANPHAM>(new Action<SANPHAM>(this.attach_SANPHAMs), new Action<SANPHAM>(this.detach_SANPHAMs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MALOAI", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MALOAI
		{
			get
			{
				return this._MALOAI;
			}
			set
			{
				if ((this._MALOAI != value))
				{
					this.OnMALOAIChanging(value);
					this.SendPropertyChanging();
					this._MALOAI = value;
					this.SendPropertyChanged("MALOAI");
					this.OnMALOAIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENLOAI", DbType="NVarChar(50)")]
		public string TENLOAI
		{
			get
			{
				return this._TENLOAI;
			}
			set
			{
				if ((this._TENLOAI != value))
				{
					this.OnTENLOAIChanging(value);
					this.SendPropertyChanging();
					this._TENLOAI = value;
					this.SendPropertyChanged("TENLOAI");
					this.OnTENLOAIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LOAI_SANPHAM", Storage="_SANPHAMs", ThisKey="MALOAI", OtherKey="MALOAI")]
		public EntitySet<SANPHAM> SANPHAMs
		{
			get
			{
				return this._SANPHAMs;
			}
			set
			{
				this._SANPHAMs.Assign(value);
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
		
		private void attach_SANPHAMs(SANPHAM entity)
		{
			this.SendPropertyChanging();
			entity.LOAI = this;
		}
		
		private void detach_SANPHAMs(SANPHAM entity)
		{
			this.SendPropertyChanging();
			entity.LOAI = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SANPHAM")]
	public partial class SANPHAM : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MASP;
		
		private string _MALOAI;
		
		private string _TENSP;
		
		private string _DVT;
		
		private System.Nullable<int> _DONGIA;
		
		private EntitySet<CHITIETHD> _CHITIETHDs;
		
		private EntityRef<LOAI> _LOAI;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMASPChanging(string value);
    partial void OnMASPChanged();
    partial void OnMALOAIChanging(string value);
    partial void OnMALOAIChanged();
    partial void OnTENSPChanging(string value);
    partial void OnTENSPChanged();
    partial void OnDVTChanging(string value);
    partial void OnDVTChanged();
    partial void OnDONGIAChanging(System.Nullable<int> value);
    partial void OnDONGIAChanged();
    #endregion
		
		public SANPHAM()
		{
			this._CHITIETHDs = new EntitySet<CHITIETHD>(new Action<CHITIETHD>(this.attach_CHITIETHDs), new Action<CHITIETHD>(this.detach_CHITIETHDs));
			this._LOAI = default(EntityRef<LOAI>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MASP", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MASP
		{
			get
			{
				return this._MASP;
			}
			set
			{
				if ((this._MASP != value))
				{
					this.OnMASPChanging(value);
					this.SendPropertyChanging();
					this._MASP = value;
					this.SendPropertyChanged("MASP");
					this.OnMASPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MALOAI", DbType="VarChar(10)")]
		public string MALOAI
		{
			get
			{
				return this._MALOAI;
			}
			set
			{
				if ((this._MALOAI != value))
				{
					if (this._LOAI.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMALOAIChanging(value);
					this.SendPropertyChanging();
					this._MALOAI = value;
					this.SendPropertyChanged("MALOAI");
					this.OnMALOAIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENSP", DbType="NVarChar(50)")]
		public string TENSP
		{
			get
			{
				return this._TENSP;
			}
			set
			{
				if ((this._TENSP != value))
				{
					this.OnTENSPChanging(value);
					this.SendPropertyChanging();
					this._TENSP = value;
					this.SendPropertyChanged("TENSP");
					this.OnTENSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DVT", DbType="NVarChar(10)")]
		public string DVT
		{
			get
			{
				return this._DVT;
			}
			set
			{
				if ((this._DVT != value))
				{
					this.OnDVTChanging(value);
					this.SendPropertyChanging();
					this._DVT = value;
					this.SendPropertyChanged("DVT");
					this.OnDVTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DONGIA", DbType="Int")]
		public System.Nullable<int> DONGIA
		{
			get
			{
				return this._DONGIA;
			}
			set
			{
				if ((this._DONGIA != value))
				{
					this.OnDONGIAChanging(value);
					this.SendPropertyChanging();
					this._DONGIA = value;
					this.SendPropertyChanged("DONGIA");
					this.OnDONGIAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SANPHAM_CHITIETHD", Storage="_CHITIETHDs", ThisKey="MASP", OtherKey="MASP")]
		public EntitySet<CHITIETHD> CHITIETHDs
		{
			get
			{
				return this._CHITIETHDs;
			}
			set
			{
				this._CHITIETHDs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LOAI_SANPHAM", Storage="_LOAI", ThisKey="MALOAI", OtherKey="MALOAI", IsForeignKey=true)]
		public LOAI LOAI
		{
			get
			{
				return this._LOAI.Entity;
			}
			set
			{
				LOAI previousValue = this._LOAI.Entity;
				if (((previousValue != value) 
							|| (this._LOAI.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._LOAI.Entity = null;
						previousValue.SANPHAMs.Remove(this);
					}
					this._LOAI.Entity = value;
					if ((value != null))
					{
						value.SANPHAMs.Add(this);
						this._MALOAI = value.MALOAI;
					}
					else
					{
						this._MALOAI = default(string);
					}
					this.SendPropertyChanged("LOAI");
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
		
		private void attach_CHITIETHDs(CHITIETHD entity)
		{
			this.SendPropertyChanging();
			entity.SANPHAM = this;
		}
		
		private void detach_CHITIETHDs(CHITIETHD entity)
		{
			this.SendPropertyChanging();
			entity.SANPHAM = null;
		}
	}
}
#pragma warning restore 1591