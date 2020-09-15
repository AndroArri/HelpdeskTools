using System;
using System.ComponentModel;
using System.Data.Linq.Mapping;

namespace helpDeskTools.Class.Database.HdToolDB.PartialClass
{
	[Table(Name = "dbo.DM_CONNECTION")]
	public partial class DM_CONNECTION : INotifyPropertyChanging, INotifyPropertyChanged
	{

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

		private int _ID;

		private string _CONNECTIONSTRING;

		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate(System.Data.Linq.ChangeAction action);
		partial void OnCreated();
		partial void OnIDChanging(int value);
		partial void OnIDChanged();
		partial void OnCONNECTIONSTRINGChanging(string value);
		partial void OnCONNECTIONSTRINGChanged();
		#endregion

		public DM_CONNECTION()
		{
			OnCreated();
		}

		public static string ID_ALIAS = "ID";

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

		public static string CONNECTIONSTRING_ALIAS = "CONNECTIONSTRING";
		[Column(Storage = "_CONNECTIONSTRING", DbType = "VarChar(500)")]
		public string CONNECTIONSTRING
		{
			get
			{
				return this._CONNECTIONSTRING;
			}
			set
			{
				if ((this._CONNECTIONSTRING != value))
				{
					this.OnCONNECTIONSTRINGChanging(value);
					this.SendPropertyChanging();
					this._CONNECTIONSTRING = value;
					this.SendPropertyChanged("CONNECTIONSTRING");
					this.OnCONNECTIONSTRINGChanged();
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
