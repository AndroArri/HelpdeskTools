using System;
using System.ComponentModel;
using System.Data.Linq.Mapping;

namespace helpDeskTools.Class.Database.HdToolDB.PartialClass
{
	[Table(Name = "dbo.DM_ROW")]
	public partial class DM_ROW : INotifyPropertyChanging, INotifyPropertyChanged
	{

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

		private int _ID;

		private System.Nullable<int> _ID_TABLE;

		private string _ROW;

		private string _DESCRIPTION;

		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate(System.Data.Linq.ChangeAction action);
		partial void OnCreated();
		partial void OnIDChanging(int value);
		partial void OnIDChanged();
		partial void OnID_TABLEChanging(System.Nullable<int> value);
		partial void OnID_TABLEChanged();
		partial void OnROWChanging(string value);
		partial void OnROWChanged();
		partial void OnDESCRIPTIONChanging(string value);
		partial void OnDESCRIPTIONChanged();
		#endregion

		public DM_ROW()
		{
			OnCreated();
		}

		[Column(Storage = "_ID", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}

		[Column(Storage = "_ID_TABLE", DbType = "Int")]
		public System.Nullable<int> ID_TABLE
		{
			get
			{
				return this._ID_TABLE;
			}
			set
			{
				if ((this._ID_TABLE != value))
				{
					this.OnID_TABLEChanging(value);
					this.SendPropertyChanging();
					this._ID_TABLE = value;
					this.SendPropertyChanged("ID_TABLE");
					this.OnID_TABLEChanged();
				}
			}
		}

		[Column(Storage = "_ROW", DbType = "VarChar(500)")]
		public string ROW
		{
			get
			{
				return this._ROW;
			}
			set
			{
				if ((this._ROW != value))
				{
					this.OnROWChanging(value);
					this.SendPropertyChanging();
					this._ROW = value;
					this.SendPropertyChanged("ROW");
					this.OnROWChanged();
				}
			}
		}

		[Column(Storage = "_DESCRIPTION", DbType = "VarChar(500)")]
		public string DESCRIPTION
		{
			get
			{
				return this._DESCRIPTION;
			}
			set
			{
				if ((this._DESCRIPTION != value))
				{
					this.OnDESCRIPTIONChanging(value);
					this.SendPropertyChanging();
					this._DESCRIPTION = value;
					this.SendPropertyChanged("DESCRIPTION");
					this.OnDESCRIPTIONChanged();
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