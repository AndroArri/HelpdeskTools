using System;
using System.ComponentModel;
using System.Data.Linq.Mapping;

namespace helpDeskTools.Class.Database.HdToolDB.PartialClass
{
	[Table(Name = "dbo.DM_TABLE")]
	public partial class DM_TABLE : INotifyPropertyChanging, INotifyPropertyChanged
	{

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

		private int _ID;

		private System.Nullable<int> _ID_CONNECTION;

		private string _TABLENAME;

		private string _DESCRIPTION;

		public const string DM_TABLE_NAME = "DM_TABLE";

		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate(System.Data.Linq.ChangeAction action);
		partial void OnCreated();
		partial void OnIDChanging(int value);
		partial void OnIDChanged();
		partial void OnID_CONNECTIONChanging(System.Nullable<int> value);
		partial void OnID_CONNECTIONChanged();
		partial void OnTABLENAMEChanging(string value);
		partial void OnTABLENAMEChanged();
		partial void OnDESCRIPTIONChanging(string value);
		partial void OnDESCRIPTIONChanged();
		#endregion

		public DM_TABLE()
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

		[Column(Storage = "_ID_CONNECTION", DbType = "Int")]
		public System.Nullable<int> ID_CONNECTION
		{
			get
			{
				return this._ID_CONNECTION;
			}
			set
			{
				if ((this._ID_CONNECTION != value))
				{
					this.OnID_CONNECTIONChanging(value);
					this.SendPropertyChanging();
					this._ID_CONNECTION = value;
					this.SendPropertyChanged("ID_CONNECTION");
					this.OnID_CONNECTIONChanged();
				}
			}
		}

		[Column(Storage = "_TABLENAME", DbType = "VarChar(500)")]
		public string TABLENAME
		{
			get
			{
				return this._TABLENAME;
			}
			set
			{
				if ((this._TABLENAME != value))
				{
					this.OnTABLENAMEChanging(value);
					this.SendPropertyChanging();
					this._TABLENAME = value;
					this.SendPropertyChanged("TABLENAME");
					this.OnTABLENAMEChanged();
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