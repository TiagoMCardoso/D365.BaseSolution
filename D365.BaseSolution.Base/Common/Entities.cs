[assembly: Microsoft.Xrm.Sdk.Client.ProxyTypesAssemblyAttribute()]

namespace D365.BaseSolution.Base.Entities
{
	
	
	[System.Runtime.Serialization.DataContractAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9479")]
	public enum AccountState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 1,
	}
	
	/// <summary>
	/// Business that represents a customer or potential customer. The company that is billed in business transactions.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("account")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9479")]
	public partial class Account : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public Account() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "account";
		
		public const string EntitySchemaName = "Account";
		
		public const string PrimaryIdAttribute = "accountid";
		
		public const string PrimaryNameAttribute = "name";
		
		public const int EntityTypeCode = 1;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		[System.Diagnostics.DebuggerNonUserCode()]
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		[System.Diagnostics.DebuggerNonUserCode()]
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		/// <summary>
		/// Select a category to indicate whether the customer account is standard or preferred.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountcategorycode")]
		public Microsoft.Xrm.Sdk.OptionSetValue AccountCategoryCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("accountcategorycode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("AccountCategoryCode");
				this.SetAttributeValue("accountcategorycode", value);
				this.OnPropertyChanged("AccountCategoryCode");
			}
		}
		
		/// <summary>
		/// Drop-down list for classifying an account.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountclassificationcode")]
		public Microsoft.Xrm.Sdk.OptionSetValue AccountClassificationCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("accountclassificationcode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("AccountClassificationCode");
				this.SetAttributeValue("accountclassificationcode", value);
				this.OnPropertyChanged("AccountClassificationCode");
			}
		}
		
		/// <summary>
		/// Unique identifier of the account.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountid")]
		public System.Nullable<System.Guid> AccountId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("accountid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("AccountId");
				this.SetAttributeValue("accountid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("AccountId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountid")]
		public override System.Guid Id
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return base.Id;
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.AccountId = value;
			}
		}
		
		/// <summary>
		/// Type an ID number or code for the account to quickly search and identify the account in system views.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountnumber")]
		public string AccountNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("accountnumber");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("AccountNumber");
				this.SetAttributeValue("accountnumber", value);
				this.OnPropertyChanged("AccountNumber");
			}
		}
		
		/// <summary>
		/// Select a rating to indicate the value of the customer account.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountratingcode")]
		public Microsoft.Xrm.Sdk.OptionSetValue AccountRatingCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("accountratingcode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("AccountRatingCode");
				this.SetAttributeValue("accountratingcode", value);
				this.OnPropertyChanged("AccountRatingCode");
			}
		}
		
		/// <summary>
		/// Unique identifier for address 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_addressid")]
		public System.Nullable<System.Guid> Address1_AddressId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("address1_addressid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_AddressId");
				this.SetAttributeValue("address1_addressid", value);
				this.OnPropertyChanged("Address1_AddressId");
			}
		}
		
		/// <summary>
		/// Select the primary address type.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_addresstypecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Address1_AddressTypeCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address1_addresstypecode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_AddressTypeCode");
				this.SetAttributeValue("address1_addresstypecode", value);
				this.OnPropertyChanged("Address1_AddressTypeCode");
			}
		}
		
		/// <summary>
		/// Type the city for the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_city")]
		public string Address1_City
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_city");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_City");
				this.SetAttributeValue("address1_city", value);
				this.OnPropertyChanged("Address1_City");
			}
		}
		
		/// <summary>
		/// Shows the complete primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_composite")]
		public string Address1_Composite
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_composite");
			}
		}
		
		/// <summary>
		/// Type the country or region for the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_country")]
		public string Address1_Country
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_country");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_Country");
				this.SetAttributeValue("address1_country", value);
				this.OnPropertyChanged("Address1_Country");
			}
		}
		
		/// <summary>
		/// Type the county for the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_county")]
		public string Address1_County
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_county");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_County");
				this.SetAttributeValue("address1_county", value);
				this.OnPropertyChanged("Address1_County");
			}
		}
		
		/// <summary>
		/// Type the fax number associated with the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_fax")]
		public string Address1_Fax
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_fax");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_Fax");
				this.SetAttributeValue("address1_fax", value);
				this.OnPropertyChanged("Address1_Fax");
			}
		}
		
		/// <summary>
		/// Select the freight terms for the primary address to make sure shipping orders are processed correctly.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_freighttermscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Address1_FreightTermsCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address1_freighttermscode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_FreightTermsCode");
				this.SetAttributeValue("address1_freighttermscode", value);
				this.OnPropertyChanged("Address1_FreightTermsCode");
			}
		}
		
		/// <summary>
		/// Type the latitude value for the primary address for use in mapping and other applications.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_latitude")]
		public System.Nullable<double> Address1_Latitude
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("address1_latitude");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_Latitude");
				this.SetAttributeValue("address1_latitude", value);
				this.OnPropertyChanged("Address1_Latitude");
			}
		}
		
		/// <summary>
		/// Type the first line of the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_line1")]
		public string Address1_Line1
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_line1");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_Line1");
				this.SetAttributeValue("address1_line1", value);
				this.OnPropertyChanged("Address1_Line1");
			}
		}
		
		/// <summary>
		/// Type the second line of the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_line2")]
		public string Address1_Line2
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_line2");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_Line2");
				this.SetAttributeValue("address1_line2", value);
				this.OnPropertyChanged("Address1_Line2");
			}
		}
		
		/// <summary>
		/// Type the third line of the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_line3")]
		public string Address1_Line3
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_line3");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_Line3");
				this.SetAttributeValue("address1_line3", value);
				this.OnPropertyChanged("Address1_Line3");
			}
		}
		
		/// <summary>
		/// Type the longitude value for the primary address for use in mapping and other applications.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_longitude")]
		public System.Nullable<double> Address1_Longitude
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("address1_longitude");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_Longitude");
				this.SetAttributeValue("address1_longitude", value);
				this.OnPropertyChanged("Address1_Longitude");
			}
		}
		
		/// <summary>
		/// Type a descriptive name for the primary address, such as Corporate Headquarters.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_name")]
		public string Address1_Name
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_name");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_Name");
				this.SetAttributeValue("address1_name", value);
				this.OnPropertyChanged("Address1_Name");
			}
		}
		
		/// <summary>
		/// Type the ZIP Code or postal code for the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_postalcode")]
		public string Address1_PostalCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_postalcode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_PostalCode");
				this.SetAttributeValue("address1_postalcode", value);
				this.OnPropertyChanged("Address1_PostalCode");
			}
		}
		
		/// <summary>
		/// Type the post office box number of the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_postofficebox")]
		public string Address1_PostOfficeBox
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_postofficebox");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_PostOfficeBox");
				this.SetAttributeValue("address1_postofficebox", value);
				this.OnPropertyChanged("Address1_PostOfficeBox");
			}
		}
		
		/// <summary>
		/// Type the name of the main contact at the account's primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_primarycontactname")]
		public string Address1_PrimaryContactName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_primarycontactname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_PrimaryContactName");
				this.SetAttributeValue("address1_primarycontactname", value);
				this.OnPropertyChanged("Address1_PrimaryContactName");
			}
		}
		
		/// <summary>
		/// Select a shipping method for deliveries sent to this address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_shippingmethodcode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Address1_ShippingMethodCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address1_shippingmethodcode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_ShippingMethodCode");
				this.SetAttributeValue("address1_shippingmethodcode", value);
				this.OnPropertyChanged("Address1_ShippingMethodCode");
			}
		}
		
		/// <summary>
		/// Type the state or province of the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_stateorprovince")]
		public string Address1_StateOrProvince
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_stateorprovince");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_StateOrProvince");
				this.SetAttributeValue("address1_stateorprovince", value);
				this.OnPropertyChanged("Address1_StateOrProvince");
			}
		}
		
		/// <summary>
		/// Type the main phone number associated with the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_telephone1")]
		public string Address1_Telephone1
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_telephone1");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_Telephone1");
				this.SetAttributeValue("address1_telephone1", value);
				this.OnPropertyChanged("Address1_Telephone1");
			}
		}
		
		/// <summary>
		/// Type a second phone number associated with the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_telephone2")]
		public string Address1_Telephone2
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_telephone2");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_Telephone2");
				this.SetAttributeValue("address1_telephone2", value);
				this.OnPropertyChanged("Address1_Telephone2");
			}
		}
		
		/// <summary>
		/// Type a third phone number associated with the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_telephone3")]
		public string Address1_Telephone3
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_telephone3");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_Telephone3");
				this.SetAttributeValue("address1_telephone3", value);
				this.OnPropertyChanged("Address1_Telephone3");
			}
		}
		
		/// <summary>
		/// Type the UPS zone of the primary address to make sure shipping charges are calculated correctly and deliveries are made promptly, if shipped by UPS.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_upszone")]
		public string Address1_UPSZone
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_upszone");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_UPSZone");
				this.SetAttributeValue("address1_upszone", value);
				this.OnPropertyChanged("Address1_UPSZone");
			}
		}
		
		/// <summary>
		/// Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_utcoffset")]
		public System.Nullable<int> Address1_UTCOffset
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("address1_utcoffset");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_UTCOffset");
				this.SetAttributeValue("address1_utcoffset", value);
				this.OnPropertyChanged("Address1_UTCOffset");
			}
		}
		
		/// <summary>
		/// Unique identifier for address 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_addressid")]
		public System.Nullable<System.Guid> Address2_AddressId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("address2_addressid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_AddressId");
				this.SetAttributeValue("address2_addressid", value);
				this.OnPropertyChanged("Address2_AddressId");
			}
		}
		
		/// <summary>
		/// Select the secondary address type.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_addresstypecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Address2_AddressTypeCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address2_addresstypecode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_AddressTypeCode");
				this.SetAttributeValue("address2_addresstypecode", value);
				this.OnPropertyChanged("Address2_AddressTypeCode");
			}
		}
		
		/// <summary>
		/// Type the city for the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_city")]
		public string Address2_City
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_city");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_City");
				this.SetAttributeValue("address2_city", value);
				this.OnPropertyChanged("Address2_City");
			}
		}
		
		/// <summary>
		/// Shows the complete secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_composite")]
		public string Address2_Composite
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_composite");
			}
		}
		
		/// <summary>
		/// Type the country or region for the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_country")]
		public string Address2_Country
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_country");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_Country");
				this.SetAttributeValue("address2_country", value);
				this.OnPropertyChanged("Address2_Country");
			}
		}
		
		/// <summary>
		/// Type the county for the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_county")]
		public string Address2_County
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_county");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_County");
				this.SetAttributeValue("address2_county", value);
				this.OnPropertyChanged("Address2_County");
			}
		}
		
		/// <summary>
		/// Type the fax number associated with the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_fax")]
		public string Address2_Fax
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_fax");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_Fax");
				this.SetAttributeValue("address2_fax", value);
				this.OnPropertyChanged("Address2_Fax");
			}
		}
		
		/// <summary>
		/// Select the freight terms for the secondary address to make sure shipping orders are processed correctly.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_freighttermscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Address2_FreightTermsCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address2_freighttermscode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_FreightTermsCode");
				this.SetAttributeValue("address2_freighttermscode", value);
				this.OnPropertyChanged("Address2_FreightTermsCode");
			}
		}
		
		/// <summary>
		/// Type the latitude value for the secondary address for use in mapping and other applications.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_latitude")]
		public System.Nullable<double> Address2_Latitude
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("address2_latitude");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_Latitude");
				this.SetAttributeValue("address2_latitude", value);
				this.OnPropertyChanged("Address2_Latitude");
			}
		}
		
		/// <summary>
		/// Type the first line of the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_line1")]
		public string Address2_Line1
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_line1");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_Line1");
				this.SetAttributeValue("address2_line1", value);
				this.OnPropertyChanged("Address2_Line1");
			}
		}
		
		/// <summary>
		/// Type the second line of the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_line2")]
		public string Address2_Line2
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_line2");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_Line2");
				this.SetAttributeValue("address2_line2", value);
				this.OnPropertyChanged("Address2_Line2");
			}
		}
		
		/// <summary>
		/// Type the third line of the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_line3")]
		public string Address2_Line3
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_line3");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_Line3");
				this.SetAttributeValue("address2_line3", value);
				this.OnPropertyChanged("Address2_Line3");
			}
		}
		
		/// <summary>
		/// Type the longitude value for the secondary address for use in mapping and other applications.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_longitude")]
		public System.Nullable<double> Address2_Longitude
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("address2_longitude");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_Longitude");
				this.SetAttributeValue("address2_longitude", value);
				this.OnPropertyChanged("Address2_Longitude");
			}
		}
		
		/// <summary>
		/// Type a descriptive name for the secondary address, such as Corporate Headquarters.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_name")]
		public string Address2_Name
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_name");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_Name");
				this.SetAttributeValue("address2_name", value);
				this.OnPropertyChanged("Address2_Name");
			}
		}
		
		/// <summary>
		/// Type the ZIP Code or postal code for the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_postalcode")]
		public string Address2_PostalCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_postalcode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_PostalCode");
				this.SetAttributeValue("address2_postalcode", value);
				this.OnPropertyChanged("Address2_PostalCode");
			}
		}
		
		/// <summary>
		/// Type the post office box number of the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_postofficebox")]
		public string Address2_PostOfficeBox
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_postofficebox");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_PostOfficeBox");
				this.SetAttributeValue("address2_postofficebox", value);
				this.OnPropertyChanged("Address2_PostOfficeBox");
			}
		}
		
		/// <summary>
		/// Type the name of the main contact at the account's secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_primarycontactname")]
		public string Address2_PrimaryContactName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_primarycontactname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_PrimaryContactName");
				this.SetAttributeValue("address2_primarycontactname", value);
				this.OnPropertyChanged("Address2_PrimaryContactName");
			}
		}
		
		/// <summary>
		/// Select a shipping method for deliveries sent to this address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_shippingmethodcode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Address2_ShippingMethodCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address2_shippingmethodcode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_ShippingMethodCode");
				this.SetAttributeValue("address2_shippingmethodcode", value);
				this.OnPropertyChanged("Address2_ShippingMethodCode");
			}
		}
		
		/// <summary>
		/// Type the state or province of the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_stateorprovince")]
		public string Address2_StateOrProvince
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_stateorprovince");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_StateOrProvince");
				this.SetAttributeValue("address2_stateorprovince", value);
				this.OnPropertyChanged("Address2_StateOrProvince");
			}
		}
		
		/// <summary>
		/// Type the main phone number associated with the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_telephone1")]
		public string Address2_Telephone1
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_telephone1");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_Telephone1");
				this.SetAttributeValue("address2_telephone1", value);
				this.OnPropertyChanged("Address2_Telephone1");
			}
		}
		
		/// <summary>
		/// Type a second phone number associated with the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_telephone2")]
		public string Address2_Telephone2
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_telephone2");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_Telephone2");
				this.SetAttributeValue("address2_telephone2", value);
				this.OnPropertyChanged("Address2_Telephone2");
			}
		}
		
		/// <summary>
		/// Type a third phone number associated with the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_telephone3")]
		public string Address2_Telephone3
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_telephone3");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_Telephone3");
				this.SetAttributeValue("address2_telephone3", value);
				this.OnPropertyChanged("Address2_Telephone3");
			}
		}
		
		/// <summary>
		/// Type the UPS zone of the secondary address to make sure shipping charges are calculated correctly and deliveries are made promptly, if shipped by UPS.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_upszone")]
		public string Address2_UPSZone
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_upszone");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_UPSZone");
				this.SetAttributeValue("address2_upszone", value);
				this.OnPropertyChanged("Address2_UPSZone");
			}
		}
		
		/// <summary>
		/// Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_utcoffset")]
		public System.Nullable<int> Address2_UTCOffset
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("address2_utcoffset");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_UTCOffset");
				this.SetAttributeValue("address2_utcoffset", value);
				this.OnPropertyChanged("Address2_UTCOffset");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_activeopportunitycount")]
		public System.Nullable<int> adx_ActiveOpportunityCount
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("adx_activeopportunitycount");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_ActiveOpportunityCount");
				this.SetAttributeValue("adx_activeopportunitycount", value);
				this.OnPropertyChanged("adx_ActiveOpportunityCount");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_averagetimetocloseanopportunity")]
		public System.Nullable<double> adx_AverageTimetoCloseanOpportunity
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("adx_averagetimetocloseanopportunity");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_AverageTimetoCloseanOpportunity");
				this.SetAttributeValue("adx_averagetimetocloseanopportunity", value);
				this.OnPropertyChanged("adx_AverageTimetoCloseanOpportunity");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_createdbyipaddress")]
		public string Adx_CreatedByIPAddress
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("adx_createdbyipaddress");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Adx_CreatedByIPAddress");
				this.SetAttributeValue("adx_createdbyipaddress", value);
				this.OnPropertyChanged("Adx_CreatedByIPAddress");
			}
		}
		
		/// <summary>
		/// Unique identifier for Contact associated with Account.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_createdbyportalcontactid")]
		public Microsoft.Xrm.Sdk.EntityReference adx_CreatedByportalcontactId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("adx_createdbyportalcontactid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_CreatedByportalcontactId");
				this.SetAttributeValue("adx_createdbyportalcontactid", value);
				this.OnPropertyChanged("adx_CreatedByportalcontactId");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_createdbyusername")]
		public string Adx_CreatedByUsername
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("adx_createdbyusername");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Adx_CreatedByUsername");
				this.SetAttributeValue("adx_createdbyusername", value);
				this.OnPropertyChanged("Adx_CreatedByUsername");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_currentpartnercapacity")]
		public System.Nullable<int> adx_CurrentPartnerCapacity
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("adx_currentpartnercapacity");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_CurrentPartnerCapacity");
				this.SetAttributeValue("adx_currentpartnercapacity", value);
				this.OnPropertyChanged("adx_CurrentPartnerCapacity");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_feedbackrate")]
		public System.Nullable<double> adx_FeedbackRate
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("adx_feedbackrate");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_FeedbackRate");
				this.SetAttributeValue("adx_feedbackrate", value);
				this.OnPropertyChanged("adx_FeedbackRate");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_lossrate")]
		public System.Nullable<double> adx_LossRate
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("adx_lossrate");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_LossRate");
				this.SetAttributeValue("adx_lossrate", value);
				this.OnPropertyChanged("adx_LossRate");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_maximumopportunityrevenue")]
		public Microsoft.Xrm.Sdk.Money adx_MaximumOpportunityRevenue
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("adx_maximumopportunityrevenue");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_MaximumOpportunityRevenue");
				this.SetAttributeValue("adx_maximumopportunityrevenue", value);
				this.OnPropertyChanged("adx_MaximumOpportunityRevenue");
			}
		}
		
		/// <summary>
		/// Value of the Maximum Opportunity Revenue in base currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_maximumopportunityrevenue_base")]
		public Microsoft.Xrm.Sdk.Money adx_maximumopportunityrevenue_Base
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("adx_maximumopportunityrevenue_base");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_minimumopportunityrevenue")]
		public Microsoft.Xrm.Sdk.Money adx_MinimumOpportunityRevenue
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("adx_minimumopportunityrevenue");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_MinimumOpportunityRevenue");
				this.SetAttributeValue("adx_minimumopportunityrevenue", value);
				this.OnPropertyChanged("adx_MinimumOpportunityRevenue");
			}
		}
		
		/// <summary>
		/// Value of the Minimum Opportunity Revenue in base currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_minimumopportunityrevenue_base")]
		public Microsoft.Xrm.Sdk.Money adx_minimumopportunityrevenue_Base
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("adx_minimumopportunityrevenue_base");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_modifiedbyipaddress")]
		public string Adx_ModifiedByIPAddress
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("adx_modifiedbyipaddress");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Adx_ModifiedByIPAddress");
				this.SetAttributeValue("adx_modifiedbyipaddress", value);
				this.OnPropertyChanged("Adx_ModifiedByIPAddress");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_modifiedbyusername")]
		public string Adx_ModifiedByUsername
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("adx_modifiedbyusername");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Adx_ModifiedByUsername");
				this.SetAttributeValue("adx_modifiedbyusername", value);
				this.OnPropertyChanged("Adx_ModifiedByUsername");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_numberofopportunitiesaccepted")]
		public System.Nullable<int> adx_NumberofOpportunitiesAccepted
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("adx_numberofopportunitiesaccepted");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_NumberofOpportunitiesAccepted");
				this.SetAttributeValue("adx_numberofopportunitiesaccepted", value);
				this.OnPropertyChanged("adx_NumberofOpportunitiesAccepted");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_numberofopportunitiesdeclined")]
		public System.Nullable<int> adx_NumberofOpportunitiesDeclined
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("adx_numberofopportunitiesdeclined");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_NumberofOpportunitiesDeclined");
				this.SetAttributeValue("adx_numberofopportunitiesdeclined", value);
				this.OnPropertyChanged("adx_NumberofOpportunitiesDeclined");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_numberofopportunitiesdelivered")]
		public System.Nullable<int> adx_NumberofOpportunitiesDelivered
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("adx_numberofopportunitiesdelivered");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_NumberofOpportunitiesDelivered");
				this.SetAttributeValue("adx_numberofopportunitiesdelivered", value);
				this.OnPropertyChanged("adx_NumberofOpportunitiesDelivered");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_numberofopportunitieswithfeedback")]
		public System.Nullable<int> adx_NumberofOpportunitieswithFeedback
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("adx_numberofopportunitieswithfeedback");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_NumberofOpportunitieswithFeedback");
				this.SetAttributeValue("adx_numberofopportunitieswithfeedback", value);
				this.OnPropertyChanged("adx_NumberofOpportunitieswithFeedback");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_numberofopportunitieswon")]
		public System.Nullable<int> adx_NumberofOpportunitiesWon
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("adx_numberofopportunitieswon");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_NumberofOpportunitiesWon");
				this.SetAttributeValue("adx_numberofopportunitieswon", value);
				this.OnPropertyChanged("adx_NumberofOpportunitiesWon");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_numberofreturnedopportunities")]
		public System.Nullable<int> adx_NumberofReturnedOpportunities
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("adx_numberofreturnedopportunities");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_NumberofReturnedOpportunities");
				this.SetAttributeValue("adx_numberofreturnedopportunities", value);
				this.OnPropertyChanged("adx_NumberofReturnedOpportunities");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_partner_status")]
		public Microsoft.Xrm.Sdk.OptionSetValue adx_partner_status
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("adx_partner_status");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_partner_status");
				this.SetAttributeValue("adx_partner_status", value);
				this.OnPropertyChanged("adx_partner_status");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_partnerhascapacity")]
		public System.Nullable<bool> adx_PartnerHasCapacity
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("adx_partnerhascapacity");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_PartnerHasCapacity");
				this.SetAttributeValue("adx_partnerhascapacity", value);
				this.OnPropertyChanged("adx_PartnerHasCapacity");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_partnerprogram_enddate")]
		public System.Nullable<System.DateTime> adx_partnerprogram_enddate
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("adx_partnerprogram_enddate");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_partnerprogram_enddate");
				this.SetAttributeValue("adx_partnerprogram_enddate", value);
				this.OnPropertyChanged("adx_partnerprogram_enddate");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_partnerprogram_startdate")]
		public System.Nullable<System.DateTime> adx_partnerprogram_startdate
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("adx_partnerprogram_startdate");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_partnerprogram_startdate");
				this.SetAttributeValue("adx_partnerprogram_startdate", value);
				this.OnPropertyChanged("adx_partnerprogram_startdate");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_partnerprogram_status")]
		public Microsoft.Xrm.Sdk.OptionSetValue adx_partnerprogram_status
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("adx_partnerprogram_status");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_partnerprogram_status");
				this.SetAttributeValue("adx_partnerprogram_status", value);
				this.OnPropertyChanged("adx_partnerprogram_status");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_partnerranking")]
		public System.Nullable<double> adx_PartnerRanking
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("adx_partnerranking");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_PartnerRanking");
				this.SetAttributeValue("adx_partnerranking", value);
				this.OnPropertyChanged("adx_PartnerRanking");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_returnrate")]
		public System.Nullable<double> adx_ReturnRate
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("adx_returnrate");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_ReturnRate");
				this.SetAttributeValue("adx_returnrate", value);
				this.OnPropertyChanged("adx_ReturnRate");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_stallrate")]
		public System.Nullable<double> adx_StallRate
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("adx_stallrate");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_StallRate");
				this.SetAttributeValue("adx_stallrate", value);
				this.OnPropertyChanged("adx_StallRate");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_touchrate")]
		public System.Nullable<double> adx_TouchRate
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("adx_touchrate");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_TouchRate");
				this.SetAttributeValue("adx_touchrate", value);
				this.OnPropertyChanged("adx_TouchRate");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_winrate")]
		public System.Nullable<double> adx_WinRate
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("adx_winrate");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_WinRate");
				this.SetAttributeValue("adx_winrate", value);
				this.OnPropertyChanged("adx_WinRate");
			}
		}
		
		/// <summary>
		/// For system use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging30")]
		public Microsoft.Xrm.Sdk.Money Aging30
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging30");
			}
		}
		
		/// <summary>
		/// The base currency equivalent of the aging 30 field.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging30_base")]
		public Microsoft.Xrm.Sdk.Money Aging30_Base
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging30_base");
			}
		}
		
		/// <summary>
		/// For system use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging60")]
		public Microsoft.Xrm.Sdk.Money Aging60
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging60");
			}
		}
		
		/// <summary>
		/// The base currency equivalent of the aging 60 field.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging60_base")]
		public Microsoft.Xrm.Sdk.Money Aging60_Base
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging60_base");
			}
		}
		
		/// <summary>
		/// For system use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging90")]
		public Microsoft.Xrm.Sdk.Money Aging90
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging90");
			}
		}
		
		/// <summary>
		/// The base currency equivalent of the aging 90 field.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging90_base")]
		public Microsoft.Xrm.Sdk.Money Aging90_Base
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging90_base");
			}
		}
		
		/// <summary>
		/// Select the legal designation or other business type of the account for contracts or reporting purposes.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businesstypecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue BusinessTypeCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("businesstypecode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("BusinessTypeCode");
				this.SetAttributeValue("businesstypecode", value);
				this.OnPropertyChanged("BusinessTypeCode");
			}
		}
		
		/// <summary>
		/// Shows who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Shows the external party who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdbyexternalparty")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedByExternalParty
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdbyexternalparty");
			}
		}
		
		/// <summary>
		/// Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Shows who created the record on behalf of another user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CreatedOnBehalfBy");
				this.SetAttributeValue("createdonbehalfby", value);
				this.OnPropertyChanged("CreatedOnBehalfBy");
			}
		}
		
		/// <summary>
		/// Type the credit limit of the account. This is a useful reference when you address invoice and accounting issues with the customer.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("creditlimit")]
		public Microsoft.Xrm.Sdk.Money CreditLimit
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("creditlimit");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CreditLimit");
				this.SetAttributeValue("creditlimit", value);
				this.OnPropertyChanged("CreditLimit");
			}
		}
		
		/// <summary>
		/// Shows the credit limit converted to the system's default base currency for reporting purposes.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("creditlimit_base")]
		public Microsoft.Xrm.Sdk.Money CreditLimit_Base
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("creditlimit_base");
			}
		}
		
		/// <summary>
		/// Select whether the credit for the account is on hold. This is a useful reference while addressing the invoice and accounting issues with the customer.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("creditonhold")]
		public System.Nullable<bool> CreditOnHold
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("creditonhold");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CreditOnHold");
				this.SetAttributeValue("creditonhold", value);
				this.OnPropertyChanged("CreditOnHold");
			}
		}
		
		/// <summary>
		/// Select the size category or range of the account for segmentation and reporting purposes.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customersizecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue CustomerSizeCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("customersizecode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CustomerSizeCode");
				this.SetAttributeValue("customersizecode", value);
				this.OnPropertyChanged("CustomerSizeCode");
			}
		}
		
		/// <summary>
		/// Select the category that best describes the relationship between the account and your organization.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customertypecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue CustomerTypeCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("customertypecode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CustomerTypeCode");
				this.SetAttributeValue("customertypecode", value);
				this.OnPropertyChanged("CustomerTypeCode");
			}
		}
		
		/// <summary>
		/// Choose the default price list associated with the account to make sure the correct product prices for this customer are applied in sales opportunities, quotes, and orders.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("defaultpricelevelid")]
		public Microsoft.Xrm.Sdk.EntityReference DefaultPriceLevelId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("defaultpricelevelid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DefaultPriceLevelId");
				this.SetAttributeValue("defaultpricelevelid", value);
				this.OnPropertyChanged("DefaultPriceLevelId");
			}
		}
		
		/// <summary>
		/// Type additional information to describe the account, such as an excerpt from the company's website.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("description")]
		public string Description
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("description");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Description");
				this.SetAttributeValue("description", value);
				this.OnPropertyChanged("Description");
			}
		}
		
		/// <summary>
		/// Select whether the account allows bulk email sent through campaigns. If Do Not Allow is selected, the account can be added to marketing lists, but is excluded from email.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotbulkemail")]
		public System.Nullable<bool> DoNotBulkEMail
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotbulkemail");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DoNotBulkEMail");
				this.SetAttributeValue("donotbulkemail", value);
				this.OnPropertyChanged("DoNotBulkEMail");
			}
		}
		
		/// <summary>
		/// Select whether the account allows bulk postal mail sent through marketing campaigns or quick campaigns. If Do Not Allow is selected, the account can be added to marketing lists, but will be excluded from the postal mail.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotbulkpostalmail")]
		public System.Nullable<bool> DoNotBulkPostalMail
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotbulkpostalmail");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DoNotBulkPostalMail");
				this.SetAttributeValue("donotbulkpostalmail", value);
				this.OnPropertyChanged("DoNotBulkPostalMail");
			}
		}
		
		/// <summary>
		/// Select whether the account allows direct email sent from Microsoft Dynamics 365.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotemail")]
		public System.Nullable<bool> DoNotEMail
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotemail");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DoNotEMail");
				this.SetAttributeValue("donotemail", value);
				this.OnPropertyChanged("DoNotEMail");
			}
		}
		
		/// <summary>
		/// Select whether the account allows faxes. If Do Not Allow is selected, the account will be excluded from fax activities distributed in marketing campaigns.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotfax")]
		public System.Nullable<bool> DoNotFax
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotfax");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DoNotFax");
				this.SetAttributeValue("donotfax", value);
				this.OnPropertyChanged("DoNotFax");
			}
		}
		
		/// <summary>
		/// Select whether the account allows phone calls. If Do Not Allow is selected, the account will be excluded from phone call activities distributed in marketing campaigns.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotphone")]
		public System.Nullable<bool> DoNotPhone
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotphone");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DoNotPhone");
				this.SetAttributeValue("donotphone", value);
				this.OnPropertyChanged("DoNotPhone");
			}
		}
		
		/// <summary>
		/// Select whether the account allows direct mail. If Do Not Allow is selected, the account will be excluded from letter activities distributed in marketing campaigns.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotpostalmail")]
		public System.Nullable<bool> DoNotPostalMail
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotpostalmail");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DoNotPostalMail");
				this.SetAttributeValue("donotpostalmail", value);
				this.OnPropertyChanged("DoNotPostalMail");
			}
		}
		
		/// <summary>
		/// Select whether the account accepts marketing materials, such as brochures or catalogs.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotsendmm")]
		public System.Nullable<bool> DoNotSendMM
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotsendmm");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DoNotSendMM");
				this.SetAttributeValue("donotsendmm", value);
				this.OnPropertyChanged("DoNotSendMM");
			}
		}
		
		/// <summary>
		/// Type the primary email address for the account.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailaddress1")]
		public string EMailAddress1
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("emailaddress1");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("EMailAddress1");
				this.SetAttributeValue("emailaddress1", value);
				this.OnPropertyChanged("EMailAddress1");
			}
		}
		
		/// <summary>
		/// Type the secondary email address for the account.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailaddress2")]
		public string EMailAddress2
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("emailaddress2");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("EMailAddress2");
				this.SetAttributeValue("emailaddress2", value);
				this.OnPropertyChanged("EMailAddress2");
			}
		}
		
		/// <summary>
		/// Type an alternate email address for the account.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailaddress3")]
		public string EMailAddress3
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("emailaddress3");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("EMailAddress3");
				this.SetAttributeValue("emailaddress3", value);
				this.OnPropertyChanged("EMailAddress3");
			}
		}
		
		/// <summary>
		/// Shows the default image for the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage")]
		public byte[] EntityImage
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<byte[]>("entityimage");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("EntityImage");
				this.SetAttributeValue("entityimage", value);
				this.OnPropertyChanged("EntityImage");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage_timestamp")]
		public System.Nullable<long> EntityImage_Timestamp
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("entityimage_timestamp");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage_url")]
		public string EntityImage_URL
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("entityimage_url");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimageid")]
		public System.Nullable<System.Guid> EntityImageId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("entityimageid");
			}
		}
		
		/// <summary>
		/// Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
		public System.Nullable<decimal> ExchangeRate
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate");
			}
		}
		
		/// <summary>
		/// Type the fax number for the account.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fax")]
		public string Fax
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("fax");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Fax");
				this.SetAttributeValue("fax", value);
				this.OnPropertyChanged("Fax");
			}
		}
		
		/// <summary>
		/// Information about whether to allow following email activity like opens, attachment views and link clicks for emails sent to the account.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("followemail")]
		public System.Nullable<bool> FollowEmail
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("followemail");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("FollowEmail");
				this.SetAttributeValue("followemail", value);
				this.OnPropertyChanged("FollowEmail");
			}
		}
		
		/// <summary>
		/// Type the URL for the account's FTP site to enable users to access data and share documents.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ftpsiteurl")]
		public string FtpSiteURL
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("ftpsiteurl");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("FtpSiteURL");
				this.SetAttributeValue("ftpsiteurl", value);
				this.OnPropertyChanged("FtpSiteURL");
			}
		}
		
		/// <summary>
		/// Unique identifier of the data import or data migration that created this record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
		public System.Nullable<int> ImportSequenceNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ImportSequenceNumber");
				this.SetAttributeValue("importsequencenumber", value);
				this.OnPropertyChanged("ImportSequenceNumber");
			}
		}
		
		/// <summary>
		/// Select the account's primary industry for use in marketing segmentation and demographic analysis.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("industrycode")]
		public Microsoft.Xrm.Sdk.OptionSetValue IndustryCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("industrycode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IndustryCode");
				this.SetAttributeValue("industrycode", value);
				this.OnPropertyChanged("IndustryCode");
			}
		}
		
		/// <summary>
		/// Contains the date and time stamp of the last on hold time.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastonholdtime")]
		public System.Nullable<System.DateTime> LastOnHoldTime
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("lastonholdtime");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("LastOnHoldTime");
				this.SetAttributeValue("lastonholdtime", value);
				this.OnPropertyChanged("LastOnHoldTime");
			}
		}
		
		/// <summary>
		/// Shows the date when the account was last included in a marketing campaign or quick campaign.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastusedincampaign")]
		public System.Nullable<System.DateTime> LastUsedInCampaign
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("lastusedincampaign");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("LastUsedInCampaign");
				this.SetAttributeValue("lastusedincampaign", value);
				this.OnPropertyChanged("LastUsedInCampaign");
			}
		}
		
		/// <summary>
		/// Used internally to track the unique linkedin id of the account record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("li_companyid")]
		public System.Nullable<int> li_CompanyId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("li_companyid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("li_CompanyId");
				this.SetAttributeValue("li_companyid", value);
				this.OnPropertyChanged("li_CompanyId");
			}
		}
		
		/// <summary>
		/// Type the market capitalization of the account to identify the company's equity, used as an indicator in financial performance analysis.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("marketcap")]
		public Microsoft.Xrm.Sdk.Money MarketCap
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("marketcap");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("MarketCap");
				this.SetAttributeValue("marketcap", value);
				this.OnPropertyChanged("MarketCap");
			}
		}
		
		/// <summary>
		/// Shows the market capitalization converted to the system's default base currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("marketcap_base")]
		public Microsoft.Xrm.Sdk.Money MarketCap_Base
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("marketcap_base");
			}
		}
		
		/// <summary>
		/// Whether is only for marketing
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("marketingonly")]
		public System.Nullable<bool> MarketingOnly
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("marketingonly");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("MarketingOnly");
				this.SetAttributeValue("marketingonly", value);
				this.OnPropertyChanged("MarketingOnly");
			}
		}
		
		/// <summary>
		/// Shows the master account that the account was merged with.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("masterid")]
		public Microsoft.Xrm.Sdk.EntityReference MasterId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("masterid");
			}
		}
		
		/// <summary>
		/// Shows whether the account has been merged with another account.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("merged")]
		public System.Nullable<bool> Merged
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("merged");
			}
		}
		
		/// <summary>
		/// Shows who last updated the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Shows the external party who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedbyexternalparty")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedByExternalParty
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedbyexternalparty");
			}
		}
		
		/// <summary>
		/// Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Shows who created the record on behalf of another user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ModifiedOnBehalfBy");
				this.SetAttributeValue("modifiedonbehalfby", value);
				this.OnPropertyChanged("ModifiedOnBehalfBy");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ms_newsandsocialid")]
		public string ms_NewsandSocialID
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("ms_newsandsocialid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ms_NewsandSocialID");
				this.SetAttributeValue("ms_newsandsocialid", value);
				this.OnPropertyChanged("ms_NewsandSocialID");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ms_traceid")]
		public string ms_TraceID
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("ms_traceid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ms_TraceID");
				this.SetAttributeValue("ms_traceid", value);
				this.OnPropertyChanged("ms_TraceID");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ms_tweetsaboutdate")]
		public string ms_TweetsAboutDate
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("ms_tweetsaboutdate");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ms_TweetsAboutDate");
				this.SetAttributeValue("ms_tweetsaboutdate", value);
				this.OnPropertyChanged("ms_TweetsAboutDate");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ms_tweetsfromdate")]
		public string ms_TweetsFromDate
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("ms_tweetsfromdate");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ms_TweetsFromDate");
				this.SetAttributeValue("ms_tweetsfromdate", value);
				this.OnPropertyChanged("ms_TweetsFromDate");
			}
		}
		
		/// <summary>
		/// Unique identifier for Account associated with Account.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msa_managingpartnerid")]
		public Microsoft.Xrm.Sdk.EntityReference msa_managingpartnerid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("msa_managingpartnerid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msa_managingpartnerid");
				this.SetAttributeValue("msa_managingpartnerid", value);
				this.OnPropertyChanged("msa_managingpartnerid");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_accountkpiid")]
		public Microsoft.Xrm.Sdk.EntityReference msdyn_accountkpiid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("msdyn_accountkpiid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_accountkpiid");
				this.SetAttributeValue("msdyn_accountkpiid", value);
				this.OnPropertyChanged("msdyn_accountkpiid");
			}
		}
		
		/// <summary>
		/// Reference to an other account to be used for billing (only to be used if billing account differs)
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_billingaccount")]
		public Microsoft.Xrm.Sdk.EntityReference msdyn_BillingAccount
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("msdyn_billingaccount");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_BillingAccount");
				this.SetAttributeValue("msdyn_billingaccount", value);
				this.OnPropertyChanged("msdyn_BillingAccount");
			}
		}
		
		/// <summary>
		/// External Account ID from other systems.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_externalaccountid")]
		public string msdyn_externalaccountid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("msdyn_externalaccountid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_externalaccountid");
				this.SetAttributeValue("msdyn_externalaccountid", value);
				this.OnPropertyChanged("msdyn_externalaccountid");
			}
		}
		
		/// <summary>
		/// Describes whether account is opted out or not
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_gdproptout")]
		public System.Nullable<bool> msdyn_gdproptout
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("msdyn_gdproptout");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_gdproptout");
				this.SetAttributeValue("msdyn_gdproptout", value);
				this.OnPropertyChanged("msdyn_gdproptout");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_preferredresource")]
		public Microsoft.Xrm.Sdk.EntityReference msdyn_PreferredResource
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("msdyn_preferredresource");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_PreferredResource");
				this.SetAttributeValue("msdyn_preferredresource", value);
				this.OnPropertyChanged("msdyn_PreferredResource");
			}
		}
		
		/// <summary>
		/// Default Sales Tax Code
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_salestaxcode")]
		public Microsoft.Xrm.Sdk.EntityReference msdyn_SalesTaxCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("msdyn_salestaxcode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_SalesTaxCode");
				this.SetAttributeValue("msdyn_salestaxcode", value);
				this.OnPropertyChanged("msdyn_SalesTaxCode");
			}
		}
		
		/// <summary>
		/// The Service Territory this account belongs to. This is used to optimize scheduling and routing
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_serviceterritory")]
		public Microsoft.Xrm.Sdk.EntityReference msdyn_ServiceTerritory
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("msdyn_serviceterritory");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_ServiceTerritory");
				this.SetAttributeValue("msdyn_serviceterritory", value);
				this.OnPropertyChanged("msdyn_ServiceTerritory");
			}
		}
		
		/// <summary>
		/// Select whether the account is tax exempt.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_taxexempt")]
		public System.Nullable<bool> msdyn_TaxExempt
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("msdyn_taxexempt");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_TaxExempt");
				this.SetAttributeValue("msdyn_taxexempt", value);
				this.OnPropertyChanged("msdyn_TaxExempt");
			}
		}
		
		/// <summary>
		/// Shows the government tax exempt number.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_taxexemptnumber")]
		public string msdyn_TaxExemptNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("msdyn_taxexemptnumber");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_TaxExemptNumber");
				this.SetAttributeValue("msdyn_taxexemptnumber", value);
				this.OnPropertyChanged("msdyn_TaxExemptNumber");
			}
		}
		
		/// <summary>
		/// Enter the travel charge to include on work orders. This value will be multiplied by the travel charge type.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_travelcharge")]
		public Microsoft.Xrm.Sdk.Money msdyn_TravelCharge
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("msdyn_travelcharge");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_TravelCharge");
				this.SetAttributeValue("msdyn_travelcharge", value);
				this.OnPropertyChanged("msdyn_TravelCharge");
			}
		}
		
		/// <summary>
		/// Value of the Travel Charge in base currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_travelcharge_base")]
		public Microsoft.Xrm.Sdk.Money msdyn_travelcharge_Base
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("msdyn_travelcharge_base");
			}
		}
		
		/// <summary>
		/// Specify how travel is charged for this account.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_travelchargetype")]
		public Microsoft.Xrm.Sdk.OptionSetValue msdyn_TravelChargeType
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("msdyn_travelchargetype");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_TravelChargeType");
				this.SetAttributeValue("msdyn_travelchargetype", value);
				this.OnPropertyChanged("msdyn_TravelChargeType");
			}
		}
		
		/// <summary>
		/// Shows the default instructions to show on new work orders.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_workorderinstructions")]
		public string msdyn_WorkOrderInstructions
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("msdyn_workorderinstructions");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_WorkOrderInstructions");
				this.SetAttributeValue("msdyn_workorderinstructions", value);
				this.OnPropertyChanged("msdyn_WorkOrderInstructions");
			}
		}
		
		/// <summary>
		/// Captures the facebook id
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyusd_facebook")]
		public string msdyusd_Facebook
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("msdyusd_facebook");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyusd_Facebook");
				this.SetAttributeValue("msdyusd_facebook", value);
				this.OnPropertyChanged("msdyusd_Facebook");
			}
		}
		
		/// <summary>
		/// Capture the twitter id
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyusd_twitter")]
		public string msdyusd_Twitter
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("msdyusd_twitter");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyusd_Twitter");
				this.SetAttributeValue("msdyusd_twitter", value);
				this.OnPropertyChanged("msdyusd_Twitter");
			}
		}
		
		/// <summary>
		/// Type the company or business name.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("name")]
		public string Name
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("name");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Name");
				this.SetAttributeValue("name", value);
				this.OnPropertyChanged("Name");
			}
		}
		
		/// <summary>
		/// Type the number of employees that work at the account for use in marketing segmentation and demographic analysis.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("numberofemployees")]
		public System.Nullable<int> NumberOfEmployees
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("numberofemployees");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("NumberOfEmployees");
				this.SetAttributeValue("numberofemployees", value);
				this.OnPropertyChanged("NumberOfEmployees");
			}
		}
		
		/// <summary>
		/// Shows how long, in minutes, that the record was on hold.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("onholdtime")]
		public System.Nullable<int> OnHoldTime
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("onholdtime");
			}
		}
		
		/// <summary>
		/// Number of open opportunities against an account and its child accounts.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("opendeals")]
		public System.Nullable<int> OpenDeals
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("opendeals");
			}
		}
		
		/// <summary>
		/// The date time for Open Deals.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("opendeals_date")]
		public System.Nullable<System.DateTime> OpenDeals_Date
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("opendeals_date");
			}
		}
		
		/// <summary>
		/// State of Open Deals.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("opendeals_state")]
		public System.Nullable<int> OpenDeals_State
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("opendeals_state");
			}
		}
		
		/// <summary>
		/// Sum of open revenue against an account and its child accounts.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("openrevenue")]
		public Microsoft.Xrm.Sdk.Money OpenRevenue
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("openrevenue");
			}
		}
		
		/// <summary>
		/// Sum of open revenue against an account and its child accounts.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("openrevenue_base")]
		public Microsoft.Xrm.Sdk.Money OpenRevenue_Base
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("openrevenue_base");
			}
		}
		
		/// <summary>
		/// The date time for Open Revenue.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("openrevenue_date")]
		public System.Nullable<System.DateTime> OpenRevenue_Date
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("openrevenue_date");
			}
		}
		
		/// <summary>
		/// State of Open Revenue.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("openrevenue_state")]
		public System.Nullable<int> OpenRevenue_State
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("openrevenue_state");
			}
		}
		
		/// <summary>
		/// Shows the lead that the account was created from if the account was created by converting a lead in Microsoft Dynamics 365. This is used to relate the account to data on the originating lead for use in reporting and analytics.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("originatingleadid")]
		public Microsoft.Xrm.Sdk.EntityReference OriginatingLeadId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("originatingleadid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OriginatingLeadId");
				this.SetAttributeValue("originatingleadid", value);
				this.OnPropertyChanged("OriginatingLeadId");
			}
		}
		
		/// <summary>
		/// Date and time that the record was migrated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
		public System.Nullable<System.DateTime> OverriddenCreatedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OverriddenCreatedOn");
				this.SetAttributeValue("overriddencreatedon", value);
				this.OnPropertyChanged("OverriddenCreatedOn");
			}
		}
		
		/// <summary>
		/// Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
		public Microsoft.Xrm.Sdk.EntityReference OwnerId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OwnerId");
				this.SetAttributeValue("ownerid", value);
				this.OnPropertyChanged("OwnerId");
			}
		}
		
		/// <summary>
		/// Select the account's ownership structure, such as public or private.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownershipcode")]
		public Microsoft.Xrm.Sdk.OptionSetValue OwnershipCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("ownershipcode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OwnershipCode");
				this.SetAttributeValue("ownershipcode", value);
				this.OnPropertyChanged("OwnershipCode");
			}
		}
		
		/// <summary>
		/// Shows the business unit that the record owner belongs to.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit");
			}
		}
		
		/// <summary>
		/// Unique identifier of the team who owns the account.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		public Microsoft.Xrm.Sdk.EntityReference OwningTeam
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who owns the account.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		public Microsoft.Xrm.Sdk.EntityReference OwningUser
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser");
			}
		}
		
		/// <summary>
		/// Choose the parent account associated with this account to show parent and child businesses in reporting and analytics.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentaccountid")]
		public Microsoft.Xrm.Sdk.EntityReference ParentAccountId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentaccountid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ParentAccountId");
				this.SetAttributeValue("parentaccountid", value);
				this.OnPropertyChanged("ParentAccountId");
			}
		}
		
		/// <summary>
		/// For system use only. Legacy Microsoft Dynamics CRM 3.0 workflow data.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("participatesinworkflow")]
		public System.Nullable<bool> ParticipatesInWorkflow
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("participatesinworkflow");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ParticipatesInWorkflow");
				this.SetAttributeValue("participatesinworkflow", value);
				this.OnPropertyChanged("ParticipatesInWorkflow");
			}
		}
		
		/// <summary>
		/// Select the payment terms to indicate when the customer needs to pay the total amount.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("paymenttermscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue PaymentTermsCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("paymenttermscode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PaymentTermsCode");
				this.SetAttributeValue("paymenttermscode", value);
				this.OnPropertyChanged("PaymentTermsCode");
			}
		}
		
		/// <summary>
		/// Select the preferred day of the week for service appointments.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredappointmentdaycode")]
		public Microsoft.Xrm.Sdk.OptionSetValue PreferredAppointmentDayCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("preferredappointmentdaycode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PreferredAppointmentDayCode");
				this.SetAttributeValue("preferredappointmentdaycode", value);
				this.OnPropertyChanged("PreferredAppointmentDayCode");
			}
		}
		
		/// <summary>
		/// Select the preferred time of day for service appointments.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredappointmenttimecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue PreferredAppointmentTimeCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("preferredappointmenttimecode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PreferredAppointmentTimeCode");
				this.SetAttributeValue("preferredappointmenttimecode", value);
				this.OnPropertyChanged("PreferredAppointmentTimeCode");
			}
		}
		
		/// <summary>
		/// Select the preferred method of contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredcontactmethodcode")]
		public Microsoft.Xrm.Sdk.OptionSetValue PreferredContactMethodCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("preferredcontactmethodcode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PreferredContactMethodCode");
				this.SetAttributeValue("preferredcontactmethodcode", value);
				this.OnPropertyChanged("PreferredContactMethodCode");
			}
		}
		
		/// <summary>
		/// Choose the account's preferred service facility or equipment to make sure services are scheduled correctly for the customer.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredequipmentid")]
		public Microsoft.Xrm.Sdk.EntityReference PreferredEquipmentId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("preferredequipmentid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PreferredEquipmentId");
				this.SetAttributeValue("preferredequipmentid", value);
				this.OnPropertyChanged("PreferredEquipmentId");
			}
		}
		
		/// <summary>
		/// Choose the account's preferred service for reference when you schedule service activities.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredserviceid")]
		public Microsoft.Xrm.Sdk.EntityReference PreferredServiceId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("preferredserviceid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PreferredServiceId");
				this.SetAttributeValue("preferredserviceid", value);
				this.OnPropertyChanged("PreferredServiceId");
			}
		}
		
		/// <summary>
		/// Choose the preferred service representative for reference when you schedule service activities for the account.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredsystemuserid")]
		public Microsoft.Xrm.Sdk.EntityReference PreferredSystemUserId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("preferredsystemuserid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PreferredSystemUserId");
				this.SetAttributeValue("preferredsystemuserid", value);
				this.OnPropertyChanged("PreferredSystemUserId");
			}
		}
		
		/// <summary>
		/// Choose the primary contact for the account to provide quick access to contact details.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("primarycontactid")]
		public Microsoft.Xrm.Sdk.EntityReference PrimaryContactId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("primarycontactid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PrimaryContactId");
				this.SetAttributeValue("primarycontactid", value);
				this.OnPropertyChanged("PrimaryContactId");
			}
		}
		
		/// <summary>
		/// Primary Satori ID for Account
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("primarysatoriid")]
		public string PrimarySatoriId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("primarysatoriid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PrimarySatoriId");
				this.SetAttributeValue("primarysatoriid", value);
				this.OnPropertyChanged("PrimarySatoriId");
			}
		}
		
		/// <summary>
		/// Primary Twitter ID for Account
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("primarytwitterid")]
		public string PrimaryTwitterId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("primarytwitterid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PrimaryTwitterId");
				this.SetAttributeValue("primarytwitterid", value);
				this.OnPropertyChanged("PrimaryTwitterId");
			}
		}
		
		/// <summary>
		/// Shows the ID of the process.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processid")]
		public System.Nullable<System.Guid> ProcessId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("processid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ProcessId");
				this.SetAttributeValue("processid", value);
				this.OnPropertyChanged("ProcessId");
			}
		}
		
		/// <summary>
		/// Type the annual revenue for the account, used as an indicator in financial performance analysis.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("revenue")]
		public Microsoft.Xrm.Sdk.Money Revenue
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("revenue");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Revenue");
				this.SetAttributeValue("revenue", value);
				this.OnPropertyChanged("Revenue");
			}
		}
		
		/// <summary>
		/// Shows the annual revenue converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("revenue_base")]
		public Microsoft.Xrm.Sdk.Money Revenue_Base
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("revenue_base");
			}
		}
		
		/// <summary>
		/// Type the number of shares available to the public for the account. This number is used as an indicator in financial performance analysis.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sharesoutstanding")]
		public System.Nullable<int> SharesOutstanding
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("sharesoutstanding");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SharesOutstanding");
				this.SetAttributeValue("sharesoutstanding", value);
				this.OnPropertyChanged("SharesOutstanding");
			}
		}
		
		/// <summary>
		/// Select a shipping method for deliveries sent to the account's address to designate the preferred carrier or other delivery option.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shippingmethodcode")]
		public Microsoft.Xrm.Sdk.OptionSetValue ShippingMethodCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("shippingmethodcode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ShippingMethodCode");
				this.SetAttributeValue("shippingmethodcode", value);
				this.OnPropertyChanged("ShippingMethodCode");
			}
		}
		
		/// <summary>
		/// Type the Standard Industrial Classification (SIC) code that indicates the account's primary industry of business, for use in marketing segmentation and demographic analysis.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sic")]
		public string SIC
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("sic");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SIC");
				this.SetAttributeValue("sic", value);
				this.OnPropertyChanged("SIC");
			}
		}
		
		/// <summary>
		/// Choose the service level agreement (SLA) that you want to apply to the Account record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("slaid")]
		public Microsoft.Xrm.Sdk.EntityReference SLAId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("slaid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SLAId");
				this.SetAttributeValue("slaid", value);
				this.OnPropertyChanged("SLAId");
			}
		}
		
		/// <summary>
		/// Last SLA that was applied to this case. This field is for internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("slainvokedid")]
		public Microsoft.Xrm.Sdk.EntityReference SLAInvokedId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("slainvokedid");
			}
		}
		
		/// <summary>
		/// Shows the ID of the stage.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stageid")]
		public System.Nullable<System.Guid> StageId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("stageid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("StageId");
				this.SetAttributeValue("stageid", value);
				this.OnPropertyChanged("StageId");
			}
		}
		
		/// <summary>
		/// Shows whether the account is active or inactive. Inactive accounts are read-only and can't be edited unless they are reactivated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<D365.BaseSolution.Base.Entities.AccountState> StateCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((D365.BaseSolution.Base.Entities.AccountState)(System.Enum.ToObject(typeof(D365.BaseSolution.Base.Entities.AccountState), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("StateCode");
				if ((value == null))
				{
					this.SetAttributeValue("statecode", null);
				}
				else
				{
					this.SetAttributeValue("statecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("StateCode");
			}
		}
		
		/// <summary>
		/// Select the account's status.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue StatusCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("StatusCode");
				this.SetAttributeValue("statuscode", value);
				this.OnPropertyChanged("StatusCode");
			}
		}
		
		/// <summary>
		/// Type the stock exchange at which the account is listed to track their stock and financial performance of the company.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stockexchange")]
		public string StockExchange
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("stockexchange");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("StockExchange");
				this.SetAttributeValue("stockexchange", value);
				this.OnPropertyChanged("StockExchange");
			}
		}
		
		/// <summary>
		/// Number of users or conversations followed the record
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("teamsfollowed")]
		public System.Nullable<int> TeamsFollowed
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("teamsfollowed");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TeamsFollowed");
				this.SetAttributeValue("teamsfollowed", value);
				this.OnPropertyChanged("TeamsFollowed");
			}
		}
		
		/// <summary>
		/// Type the main phone number for this account.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("telephone1")]
		public string Telephone1
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("telephone1");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Telephone1");
				this.SetAttributeValue("telephone1", value);
				this.OnPropertyChanged("Telephone1");
			}
		}
		
		/// <summary>
		/// Type a second phone number for this account.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("telephone2")]
		public string Telephone2
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("telephone2");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Telephone2");
				this.SetAttributeValue("telephone2", value);
				this.OnPropertyChanged("Telephone2");
			}
		}
		
		/// <summary>
		/// Type a third phone number for this account.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("telephone3")]
		public string Telephone3
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("telephone3");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Telephone3");
				this.SetAttributeValue("telephone3", value);
				this.OnPropertyChanged("Telephone3");
			}
		}
		
		/// <summary>
		/// Select a region or territory for the account for use in segmentation and analysis.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("territorycode")]
		public Microsoft.Xrm.Sdk.OptionSetValue TerritoryCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("territorycode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TerritoryCode");
				this.SetAttributeValue("territorycode", value);
				this.OnPropertyChanged("TerritoryCode");
			}
		}
		
		/// <summary>
		/// Choose the sales region or territory for the account to make sure the account is assigned to the correct representative and for use in segmentation and analysis.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("territoryid")]
		public Microsoft.Xrm.Sdk.EntityReference TerritoryId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("territoryid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TerritoryId");
				this.SetAttributeValue("territoryid", value);
				this.OnPropertyChanged("TerritoryId");
			}
		}
		
		/// <summary>
		/// Type the stock exchange symbol for the account to track financial performance of the company. You can click the code entered in this field to access the latest trading information from MSN Money.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("tickersymbol")]
		public string TickerSymbol
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("tickersymbol");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TickerSymbol");
				this.SetAttributeValue("tickersymbol", value);
				this.OnPropertyChanged("TickerSymbol");
			}
		}
		
		/// <summary>
		/// Total time spent for emails (read and write) and meetings by me in relation to account record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timespentbymeonemailandmeetings")]
		public string TimeSpentByMeOnEmailAndMeetings
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("timespentbymeonemailandmeetings");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
		public System.Nullable<int> TimeZoneRuleVersionNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TimeZoneRuleVersionNumber");
				this.SetAttributeValue("timezoneruleversionnumber", value);
				this.OnPropertyChanged("TimeZoneRuleVersionNumber");
			}
		}
		
		/// <summary>
		/// Choose the local currency for the record to make sure budgets are reported in the correct currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		public Microsoft.Xrm.Sdk.EntityReference TransactionCurrencyId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("transactioncurrencyid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TransactionCurrencyId");
				this.SetAttributeValue("transactioncurrencyid", value);
				this.OnPropertyChanged("TransactionCurrencyId");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("traversedpath")]
		public string TraversedPath
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("traversedpath");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TraversedPath");
				this.SetAttributeValue("traversedpath", value);
				this.OnPropertyChanged("TraversedPath");
			}
		}
		
		/// <summary>
		/// Time zone code that was in use when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
		public System.Nullable<int> UTCConversionTimeZoneCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("UTCConversionTimeZoneCode");
				this.SetAttributeValue("utcconversiontimezonecode", value);
				this.OnPropertyChanged("UTCConversionTimeZoneCode");
			}
		}
		
		/// <summary>
		/// Version number of the account.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// Type the account's website URL to get quick details about the company profile.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("websiteurl")]
		public string WebSiteURL
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("websiteurl");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("WebSiteURL");
				this.SetAttributeValue("websiteurl", value);
				this.OnPropertyChanged("WebSiteURL");
			}
		}
		
		/// <summary>
		/// Type the phonetic spelling of the company name, if specified in Japanese, to make sure the name is pronounced correctly in phone calls and other communications.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yominame")]
		public string YomiName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("yominame");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("YomiName");
				this.SetAttributeValue("yominame", value);
				this.OnPropertyChanged("YomiName");
			}
		}
		
		/// <summary>
		/// 1:N account_master_account
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_master_account", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
		public System.Collections.Generic.IEnumerable<D365.BaseSolution.Base.Entities.Account> Referencedaccount_master_account
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<D365.BaseSolution.Base.Entities.Account>("account_master_account", Microsoft.Xrm.Sdk.EntityRole.Referenced);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Referencedaccount_master_account");
				this.SetRelatedEntities<D365.BaseSolution.Base.Entities.Account>("account_master_account", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
				this.OnPropertyChanged("Referencedaccount_master_account");
			}
		}
		
		/// <summary>
		/// 1:N account_parent_account
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_parent_account", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
		public System.Collections.Generic.IEnumerable<D365.BaseSolution.Base.Entities.Account> Referencedaccount_parent_account
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<D365.BaseSolution.Base.Entities.Account>("account_parent_account", Microsoft.Xrm.Sdk.EntityRole.Referenced);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Referencedaccount_parent_account");
				this.SetRelatedEntities<D365.BaseSolution.Base.Entities.Account>("account_parent_account", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
				this.OnPropertyChanged("Referencedaccount_parent_account");
			}
		}
		
		/// <summary>
		/// 1:N contact_customer_accounts
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_customer_accounts")]
		public System.Collections.Generic.IEnumerable<D365.BaseSolution.Base.Entities.Contact> contact_customer_accounts
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<D365.BaseSolution.Base.Entities.Contact>("contact_customer_accounts", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("contact_customer_accounts");
				this.SetRelatedEntities<D365.BaseSolution.Base.Entities.Contact>("contact_customer_accounts", null, value);
				this.OnPropertyChanged("contact_customer_accounts");
			}
		}
		
		/// <summary>
		/// 1:N msa_account_managingpartner
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msa_account_managingpartner", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
		public System.Collections.Generic.IEnumerable<D365.BaseSolution.Base.Entities.Account> Referencedmsa_account_managingpartner
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<D365.BaseSolution.Base.Entities.Account>("msa_account_managingpartner", Microsoft.Xrm.Sdk.EntityRole.Referenced);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Referencedmsa_account_managingpartner");
				this.SetRelatedEntities<D365.BaseSolution.Base.Entities.Account>("msa_account_managingpartner", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
				this.OnPropertyChanged("Referencedmsa_account_managingpartner");
			}
		}
		
		/// <summary>
		/// 1:N msa_contact_managingpartner
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msa_contact_managingpartner")]
		public System.Collections.Generic.IEnumerable<D365.BaseSolution.Base.Entities.Contact> msa_contact_managingpartner
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<D365.BaseSolution.Base.Entities.Contact>("msa_contact_managingpartner", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msa_contact_managingpartner");
				this.SetRelatedEntities<D365.BaseSolution.Base.Entities.Contact>("msa_contact_managingpartner", null, value);
				this.OnPropertyChanged("msa_contact_managingpartner");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_account_account_BillingAccount
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_account_account_BillingAccount", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
		public System.Collections.Generic.IEnumerable<D365.BaseSolution.Base.Entities.Account> Referencedmsdyn_account_account_BillingAccount
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<D365.BaseSolution.Base.Entities.Account>("msdyn_account_account_BillingAccount", Microsoft.Xrm.Sdk.EntityRole.Referenced);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Referencedmsdyn_account_account_BillingAccount");
				this.SetRelatedEntities<D365.BaseSolution.Base.Entities.Account>("msdyn_account_account_BillingAccount", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
				this.OnPropertyChanged("Referencedmsdyn_account_account_BillingAccount");
			}
		}
		
		/// <summary>
		/// N:N adx_account_contact_partnersellers
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("adx_account_contact_partnersellers")]
		public System.Collections.Generic.IEnumerable<D365.BaseSolution.Base.Entities.Contact> adx_account_contact_partnersellers
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<D365.BaseSolution.Base.Entities.Contact>("adx_account_contact_partnersellers", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_account_contact_partnersellers");
				this.SetRelatedEntities<D365.BaseSolution.Base.Entities.Contact>("adx_account_contact_partnersellers", null, value);
				this.OnPropertyChanged("adx_account_contact_partnersellers");
			}
		}
		
		/// <summary>
		/// N:N cr4f0_Account_Contact_Contact
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("cr4f0_Account_Contact_Contact")]
		public System.Collections.Generic.IEnumerable<D365.BaseSolution.Base.Entities.Contact> cr4f0_Account_Contact_Contact
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<D365.BaseSolution.Base.Entities.Contact>("cr4f0_Account_Contact_Contact", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("cr4f0_Account_Contact_Contact");
				this.SetRelatedEntities<D365.BaseSolution.Base.Entities.Contact>("cr4f0_Account_Contact_Contact", null, value);
				this.OnPropertyChanged("cr4f0_Account_Contact_Contact");
			}
		}
		
		/// <summary>
		/// N:1 account_master_account
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("masterid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_master_account", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
		public D365.BaseSolution.Base.Entities.Account Referencingaccount_master_account
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<D365.BaseSolution.Base.Entities.Account>("account_master_account", Microsoft.Xrm.Sdk.EntityRole.Referencing);
			}
		}
		
		/// <summary>
		/// N:1 account_parent_account
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentaccountid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_parent_account", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
		public D365.BaseSolution.Base.Entities.Account Referencingaccount_parent_account
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<D365.BaseSolution.Base.Entities.Account>("account_parent_account", Microsoft.Xrm.Sdk.EntityRole.Referencing);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Referencingaccount_parent_account");
				this.SetRelatedEntity<D365.BaseSolution.Base.Entities.Account>("account_parent_account", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
				this.OnPropertyChanged("Referencingaccount_parent_account");
			}
		}
		
		/// <summary>
		/// N:1 account_primary_contact
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("primarycontactid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_primary_contact")]
		public D365.BaseSolution.Base.Entities.Contact account_primary_contact
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<D365.BaseSolution.Base.Entities.Contact>("account_primary_contact", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("account_primary_contact");
				this.SetRelatedEntity<D365.BaseSolution.Base.Entities.Contact>("account_primary_contact", null, value);
				this.OnPropertyChanged("account_primary_contact");
			}
		}
		
		/// <summary>
		/// N:1 adx_account_created_by_portal_contact
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_createdbyportalcontactid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("adx_account_created_by_portal_contact")]
		public D365.BaseSolution.Base.Entities.Contact adx_account_created_by_portal_contact
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<D365.BaseSolution.Base.Entities.Contact>("adx_account_created_by_portal_contact", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_account_created_by_portal_contact");
				this.SetRelatedEntity<D365.BaseSolution.Base.Entities.Contact>("adx_account_created_by_portal_contact", null, value);
				this.OnPropertyChanged("adx_account_created_by_portal_contact");
			}
		}
		
		/// <summary>
		/// N:1 msa_account_managingpartner
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msa_managingpartnerid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msa_account_managingpartner", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
		public D365.BaseSolution.Base.Entities.Account Referencingmsa_account_managingpartner
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<D365.BaseSolution.Base.Entities.Account>("msa_account_managingpartner", Microsoft.Xrm.Sdk.EntityRole.Referencing);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Referencingmsa_account_managingpartner");
				this.SetRelatedEntity<D365.BaseSolution.Base.Entities.Account>("msa_account_managingpartner", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
				this.OnPropertyChanged("Referencingmsa_account_managingpartner");
			}
		}
		
		/// <summary>
		/// N:1 msdyn_account_account_BillingAccount
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_billingaccount")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_account_account_BillingAccount", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
		public D365.BaseSolution.Base.Entities.Account Referencingmsdyn_account_account_BillingAccount
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<D365.BaseSolution.Base.Entities.Account>("msdyn_account_account_BillingAccount", Microsoft.Xrm.Sdk.EntityRole.Referencing);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Referencingmsdyn_account_account_BillingAccount");
				this.SetRelatedEntity<D365.BaseSolution.Base.Entities.Account>("msdyn_account_account_BillingAccount", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
				this.OnPropertyChanged("Referencingmsdyn_account_account_BillingAccount");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public Account(object anonymousType) : 
				this()
		{
            foreach (var p in anonymousType.GetType().GetProperties())
            {
                var value = p.GetValue(anonymousType, null);
                var name = p.Name.ToLower();
            
                if (name.EndsWith("enum") && value.GetType().BaseType == typeof(System.Enum))
                {
                    value = new Microsoft.Xrm.Sdk.OptionSetValue((int) value);
                    name = name.Remove(name.Length - "enum".Length);
                }
            
                switch (name)
                {
                    case "id":
                        base.Id = (System.Guid)value;
                        Attributes["accountid"] = base.Id;
                        break;
                    case "accountid":
                        var id = (System.Nullable<System.Guid>) value;
                        if(id == null){ continue; }
                        base.Id = id.Value;
                        Attributes[name] = base.Id;
                        break;
                    case "formattedvalues":
                        // Add Support for FormattedValues
                        FormattedValues.AddRange((Microsoft.Xrm.Sdk.FormattedValueCollection)value);
                        break;
                    default:
                        Attributes[name] = value;
                        break;
                }
            }
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountcategorycode")]
		public virtual Account_AccountCategoryCode? AccountCategoryCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((Account_AccountCategoryCode?)(EntityOptionSetEnum.GetEnum(this, "accountcategorycode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				AccountCategoryCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountclassificationcode")]
		public virtual Account_AccountClassificationCode? AccountClassificationCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((Account_AccountClassificationCode?)(EntityOptionSetEnum.GetEnum(this, "accountclassificationcode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				AccountClassificationCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountratingcode")]
		public virtual Account_AccountRatingCode? AccountRatingCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((Account_AccountRatingCode?)(EntityOptionSetEnum.GetEnum(this, "accountratingcode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				AccountRatingCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_addresstypecode")]
		public virtual Account_Address1_AddressTypeCode? Address1_AddressTypeCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((Account_Address1_AddressTypeCode?)(EntityOptionSetEnum.GetEnum(this, "address1_addresstypecode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				Address1_AddressTypeCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_freighttermscode")]
		public virtual Account_Address1_FreightTermsCode? Address1_FreightTermsCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((Account_Address1_FreightTermsCode?)(EntityOptionSetEnum.GetEnum(this, "address1_freighttermscode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				Address1_FreightTermsCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_shippingmethodcode")]
		public virtual Account_Address1_ShippingMethodCode? Address1_ShippingMethodCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((Account_Address1_ShippingMethodCode?)(EntityOptionSetEnum.GetEnum(this, "address1_shippingmethodcode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				Address1_ShippingMethodCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_addresstypecode")]
		public virtual Account_Address2_AddressTypeCode? Address2_AddressTypeCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((Account_Address2_AddressTypeCode?)(EntityOptionSetEnum.GetEnum(this, "address2_addresstypecode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				Address2_AddressTypeCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_freighttermscode")]
		public virtual Account_Address2_FreightTermsCode? Address2_FreightTermsCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((Account_Address2_FreightTermsCode?)(EntityOptionSetEnum.GetEnum(this, "address2_freighttermscode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				Address2_FreightTermsCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_shippingmethodcode")]
		public virtual Account_Address2_ShippingMethodCode? Address2_ShippingMethodCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((Account_Address2_ShippingMethodCode?)(EntityOptionSetEnum.GetEnum(this, "address2_shippingmethodcode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				Address2_ShippingMethodCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_partner_status")]
		public virtual Account_adx_partner_status? adx_partner_statusEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((Account_adx_partner_status?)(EntityOptionSetEnum.GetEnum(this, "adx_partner_status")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				adx_partner_status = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_partnerprogram_status")]
		public virtual Account_adx_partnerprogram_status? adx_partnerprogram_statusEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((Account_adx_partnerprogram_status?)(EntityOptionSetEnum.GetEnum(this, "adx_partnerprogram_status")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				adx_partnerprogram_status = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businesstypecode")]
		public virtual Account_BusinessTypeCode? BusinessTypeCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((Account_BusinessTypeCode?)(EntityOptionSetEnum.GetEnum(this, "businesstypecode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				BusinessTypeCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customersizecode")]
		public virtual Account_CustomerSizeCode? CustomerSizeCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((Account_CustomerSizeCode?)(EntityOptionSetEnum.GetEnum(this, "customersizecode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				CustomerSizeCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customertypecode")]
		public virtual Account_CustomerTypeCode? CustomerTypeCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((Account_CustomerTypeCode?)(EntityOptionSetEnum.GetEnum(this, "customertypecode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				CustomerTypeCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("industrycode")]
		public virtual Account_IndustryCode? IndustryCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((Account_IndustryCode?)(EntityOptionSetEnum.GetEnum(this, "industrycode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				IndustryCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_travelchargetype")]
		public virtual msdyn_TravelChargeType? msdyn_TravelChargeTypeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((msdyn_TravelChargeType?)(EntityOptionSetEnum.GetEnum(this, "msdyn_travelchargetype")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				msdyn_TravelChargeType = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownershipcode")]
		public virtual Account_OwnershipCode? OwnershipCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((Account_OwnershipCode?)(EntityOptionSetEnum.GetEnum(this, "ownershipcode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				OwnershipCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("paymenttermscode")]
		public virtual Account_PaymentTermsCode? PaymentTermsCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((Account_PaymentTermsCode?)(EntityOptionSetEnum.GetEnum(this, "paymenttermscode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				PaymentTermsCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredappointmentdaycode")]
		public virtual Account_PreferredAppointmentDayCode? PreferredAppointmentDayCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((Account_PreferredAppointmentDayCode?)(EntityOptionSetEnum.GetEnum(this, "preferredappointmentdaycode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				PreferredAppointmentDayCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredappointmenttimecode")]
		public virtual Account_PreferredAppointmentTimeCode? PreferredAppointmentTimeCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((Account_PreferredAppointmentTimeCode?)(EntityOptionSetEnum.GetEnum(this, "preferredappointmenttimecode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				PreferredAppointmentTimeCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredcontactmethodcode")]
		public virtual Account_PreferredContactMethodCode? PreferredContactMethodCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((Account_PreferredContactMethodCode?)(EntityOptionSetEnum.GetEnum(this, "preferredcontactmethodcode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				PreferredContactMethodCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shippingmethodcode")]
		public virtual Account_ShippingMethodCode? ShippingMethodCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((Account_ShippingMethodCode?)(EntityOptionSetEnum.GetEnum(this, "shippingmethodcode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				ShippingMethodCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public virtual Account_StatusCode? StatusCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((Account_StatusCode?)(EntityOptionSetEnum.GetEnum(this, "statuscode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				StatusCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("territorycode")]
		public virtual Account_TerritoryCode? TerritoryCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((Account_TerritoryCode?)(EntityOptionSetEnum.GetEnum(this, "territorycode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				TerritoryCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9479")]
	public enum ContactState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 1,
	}
	
	/// <summary>
	/// Person with whom a business unit has a relationship, such as customer, supplier, and colleague.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("contact")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9479")]
	public partial class Contact : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public Contact() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "contact";
		
		public const string EntitySchemaName = "Contact";
		
		public const string PrimaryIdAttribute = "contactid";
		
		public const string PrimaryNameAttribute = "fullname";
		
		public const int EntityTypeCode = 2;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		[System.Diagnostics.DebuggerNonUserCode()]
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		[System.Diagnostics.DebuggerNonUserCode()]
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		/// <summary>
		/// Unique identifier of the account with which the contact is associated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountid")]
		public Microsoft.Xrm.Sdk.EntityReference AccountId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("accountid");
			}
		}
		
		/// <summary>
		/// Select the contact's role within the company or sales process, such as decision maker, employee, or influencer.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountrolecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue AccountRoleCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("accountrolecode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("AccountRoleCode");
				this.SetAttributeValue("accountrolecode", value);
				this.OnPropertyChanged("AccountRoleCode");
			}
		}
		
		/// <summary>
		/// Unique identifier for address 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_addressid")]
		public System.Nullable<System.Guid> Address1_AddressId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("address1_addressid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_AddressId");
				this.SetAttributeValue("address1_addressid", value);
				this.OnPropertyChanged("Address1_AddressId");
			}
		}
		
		/// <summary>
		/// Select the primary address type.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_addresstypecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Address1_AddressTypeCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address1_addresstypecode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_AddressTypeCode");
				this.SetAttributeValue("address1_addresstypecode", value);
				this.OnPropertyChanged("Address1_AddressTypeCode");
			}
		}
		
		/// <summary>
		/// Type the city for the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_city")]
		public string Address1_City
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_city");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_City");
				this.SetAttributeValue("address1_city", value);
				this.OnPropertyChanged("Address1_City");
			}
		}
		
		/// <summary>
		/// Shows the complete primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_composite")]
		public string Address1_Composite
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_composite");
			}
		}
		
		/// <summary>
		/// Type the country or region for the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_country")]
		public string Address1_Country
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_country");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_Country");
				this.SetAttributeValue("address1_country", value);
				this.OnPropertyChanged("Address1_Country");
			}
		}
		
		/// <summary>
		/// Type the county for the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_county")]
		public string Address1_County
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_county");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_County");
				this.SetAttributeValue("address1_county", value);
				this.OnPropertyChanged("Address1_County");
			}
		}
		
		/// <summary>
		/// Type the fax number associated with the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_fax")]
		public string Address1_Fax
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_fax");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_Fax");
				this.SetAttributeValue("address1_fax", value);
				this.OnPropertyChanged("Address1_Fax");
			}
		}
		
		/// <summary>
		/// Select the freight terms for the primary address to make sure shipping orders are processed correctly.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_freighttermscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Address1_FreightTermsCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address1_freighttermscode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_FreightTermsCode");
				this.SetAttributeValue("address1_freighttermscode", value);
				this.OnPropertyChanged("Address1_FreightTermsCode");
			}
		}
		
		/// <summary>
		/// Type the latitude value for the primary address for use in mapping and other applications.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_latitude")]
		public System.Nullable<double> Address1_Latitude
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("address1_latitude");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_Latitude");
				this.SetAttributeValue("address1_latitude", value);
				this.OnPropertyChanged("Address1_Latitude");
			}
		}
		
		/// <summary>
		/// Type the first line of the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_line1")]
		public string Address1_Line1
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_line1");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_Line1");
				this.SetAttributeValue("address1_line1", value);
				this.OnPropertyChanged("Address1_Line1");
			}
		}
		
		/// <summary>
		/// Type the second line of the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_line2")]
		public string Address1_Line2
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_line2");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_Line2");
				this.SetAttributeValue("address1_line2", value);
				this.OnPropertyChanged("Address1_Line2");
			}
		}
		
		/// <summary>
		/// Type the third line of the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_line3")]
		public string Address1_Line3
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_line3");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_Line3");
				this.SetAttributeValue("address1_line3", value);
				this.OnPropertyChanged("Address1_Line3");
			}
		}
		
		/// <summary>
		/// Type the longitude value for the primary address for use in mapping and other applications.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_longitude")]
		public System.Nullable<double> Address1_Longitude
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("address1_longitude");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_Longitude");
				this.SetAttributeValue("address1_longitude", value);
				this.OnPropertyChanged("Address1_Longitude");
			}
		}
		
		/// <summary>
		/// Type a descriptive name for the primary address, such as Corporate Headquarters.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_name")]
		public string Address1_Name
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_name");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_Name");
				this.SetAttributeValue("address1_name", value);
				this.OnPropertyChanged("Address1_Name");
			}
		}
		
		/// <summary>
		/// Type the ZIP Code or postal code for the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_postalcode")]
		public string Address1_PostalCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_postalcode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_PostalCode");
				this.SetAttributeValue("address1_postalcode", value);
				this.OnPropertyChanged("Address1_PostalCode");
			}
		}
		
		/// <summary>
		/// Type the post office box number of the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_postofficebox")]
		public string Address1_PostOfficeBox
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_postofficebox");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_PostOfficeBox");
				this.SetAttributeValue("address1_postofficebox", value);
				this.OnPropertyChanged("Address1_PostOfficeBox");
			}
		}
		
		/// <summary>
		/// Type the name of the main contact at the account's primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_primarycontactname")]
		public string Address1_PrimaryContactName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_primarycontactname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_PrimaryContactName");
				this.SetAttributeValue("address1_primarycontactname", value);
				this.OnPropertyChanged("Address1_PrimaryContactName");
			}
		}
		
		/// <summary>
		/// Select a shipping method for deliveries sent to this address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_shippingmethodcode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Address1_ShippingMethodCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address1_shippingmethodcode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_ShippingMethodCode");
				this.SetAttributeValue("address1_shippingmethodcode", value);
				this.OnPropertyChanged("Address1_ShippingMethodCode");
			}
		}
		
		/// <summary>
		/// Type the state or province of the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_stateorprovince")]
		public string Address1_StateOrProvince
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_stateorprovince");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_StateOrProvince");
				this.SetAttributeValue("address1_stateorprovince", value);
				this.OnPropertyChanged("Address1_StateOrProvince");
			}
		}
		
		/// <summary>
		/// Type the main phone number associated with the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_telephone1")]
		public string Address1_Telephone1
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_telephone1");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_Telephone1");
				this.SetAttributeValue("address1_telephone1", value);
				this.OnPropertyChanged("Address1_Telephone1");
			}
		}
		
		/// <summary>
		/// Type a second phone number associated with the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_telephone2")]
		public string Address1_Telephone2
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_telephone2");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_Telephone2");
				this.SetAttributeValue("address1_telephone2", value);
				this.OnPropertyChanged("Address1_Telephone2");
			}
		}
		
		/// <summary>
		/// Type a third phone number associated with the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_telephone3")]
		public string Address1_Telephone3
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_telephone3");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_Telephone3");
				this.SetAttributeValue("address1_telephone3", value);
				this.OnPropertyChanged("Address1_Telephone3");
			}
		}
		
		/// <summary>
		/// Type the UPS zone of the primary address to make sure shipping charges are calculated correctly and deliveries are made promptly, if shipped by UPS.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_upszone")]
		public string Address1_UPSZone
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_upszone");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_UPSZone");
				this.SetAttributeValue("address1_upszone", value);
				this.OnPropertyChanged("Address1_UPSZone");
			}
		}
		
		/// <summary>
		/// Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_utcoffset")]
		public System.Nullable<int> Address1_UTCOffset
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("address1_utcoffset");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_UTCOffset");
				this.SetAttributeValue("address1_utcoffset", value);
				this.OnPropertyChanged("Address1_UTCOffset");
			}
		}
		
		/// <summary>
		/// Unique identifier for address 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_addressid")]
		public System.Nullable<System.Guid> Address2_AddressId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("address2_addressid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_AddressId");
				this.SetAttributeValue("address2_addressid", value);
				this.OnPropertyChanged("Address2_AddressId");
			}
		}
		
		/// <summary>
		/// Select the secondary address type.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_addresstypecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Address2_AddressTypeCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address2_addresstypecode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_AddressTypeCode");
				this.SetAttributeValue("address2_addresstypecode", value);
				this.OnPropertyChanged("Address2_AddressTypeCode");
			}
		}
		
		/// <summary>
		/// Type the city for the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_city")]
		public string Address2_City
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_city");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_City");
				this.SetAttributeValue("address2_city", value);
				this.OnPropertyChanged("Address2_City");
			}
		}
		
		/// <summary>
		/// Shows the complete secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_composite")]
		public string Address2_Composite
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_composite");
			}
		}
		
		/// <summary>
		/// Type the country or region for the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_country")]
		public string Address2_Country
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_country");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_Country");
				this.SetAttributeValue("address2_country", value);
				this.OnPropertyChanged("Address2_Country");
			}
		}
		
		/// <summary>
		/// Type the county for the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_county")]
		public string Address2_County
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_county");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_County");
				this.SetAttributeValue("address2_county", value);
				this.OnPropertyChanged("Address2_County");
			}
		}
		
		/// <summary>
		/// Type the fax number associated with the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_fax")]
		public string Address2_Fax
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_fax");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_Fax");
				this.SetAttributeValue("address2_fax", value);
				this.OnPropertyChanged("Address2_Fax");
			}
		}
		
		/// <summary>
		/// Select the freight terms for the secondary address to make sure shipping orders are processed correctly.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_freighttermscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Address2_FreightTermsCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address2_freighttermscode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_FreightTermsCode");
				this.SetAttributeValue("address2_freighttermscode", value);
				this.OnPropertyChanged("Address2_FreightTermsCode");
			}
		}
		
		/// <summary>
		/// Type the latitude value for the secondary address for use in mapping and other applications.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_latitude")]
		public System.Nullable<double> Address2_Latitude
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("address2_latitude");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_Latitude");
				this.SetAttributeValue("address2_latitude", value);
				this.OnPropertyChanged("Address2_Latitude");
			}
		}
		
		/// <summary>
		/// Type the first line of the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_line1")]
		public string Address2_Line1
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_line1");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_Line1");
				this.SetAttributeValue("address2_line1", value);
				this.OnPropertyChanged("Address2_Line1");
			}
		}
		
		/// <summary>
		/// Type the second line of the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_line2")]
		public string Address2_Line2
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_line2");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_Line2");
				this.SetAttributeValue("address2_line2", value);
				this.OnPropertyChanged("Address2_Line2");
			}
		}
		
		/// <summary>
		/// Type the third line of the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_line3")]
		public string Address2_Line3
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_line3");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_Line3");
				this.SetAttributeValue("address2_line3", value);
				this.OnPropertyChanged("Address2_Line3");
			}
		}
		
		/// <summary>
		/// Type the longitude value for the secondary address for use in mapping and other applications.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_longitude")]
		public System.Nullable<double> Address2_Longitude
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("address2_longitude");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_Longitude");
				this.SetAttributeValue("address2_longitude", value);
				this.OnPropertyChanged("Address2_Longitude");
			}
		}
		
		/// <summary>
		/// Type a descriptive name for the secondary address, such as Corporate Headquarters.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_name")]
		public string Address2_Name
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_name");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_Name");
				this.SetAttributeValue("address2_name", value);
				this.OnPropertyChanged("Address2_Name");
			}
		}
		
		/// <summary>
		/// Type the ZIP Code or postal code for the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_postalcode")]
		public string Address2_PostalCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_postalcode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_PostalCode");
				this.SetAttributeValue("address2_postalcode", value);
				this.OnPropertyChanged("Address2_PostalCode");
			}
		}
		
		/// <summary>
		/// Type the post office box number of the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_postofficebox")]
		public string Address2_PostOfficeBox
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_postofficebox");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_PostOfficeBox");
				this.SetAttributeValue("address2_postofficebox", value);
				this.OnPropertyChanged("Address2_PostOfficeBox");
			}
		}
		
		/// <summary>
		/// Type the name of the main contact at the account's secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_primarycontactname")]
		public string Address2_PrimaryContactName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_primarycontactname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_PrimaryContactName");
				this.SetAttributeValue("address2_primarycontactname", value);
				this.OnPropertyChanged("Address2_PrimaryContactName");
			}
		}
		
		/// <summary>
		/// Select a shipping method for deliveries sent to this address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_shippingmethodcode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Address2_ShippingMethodCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address2_shippingmethodcode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_ShippingMethodCode");
				this.SetAttributeValue("address2_shippingmethodcode", value);
				this.OnPropertyChanged("Address2_ShippingMethodCode");
			}
		}
		
		/// <summary>
		/// Type the state or province of the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_stateorprovince")]
		public string Address2_StateOrProvince
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_stateorprovince");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_StateOrProvince");
				this.SetAttributeValue("address2_stateorprovince", value);
				this.OnPropertyChanged("Address2_StateOrProvince");
			}
		}
		
		/// <summary>
		/// Type the main phone number associated with the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_telephone1")]
		public string Address2_Telephone1
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_telephone1");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_Telephone1");
				this.SetAttributeValue("address2_telephone1", value);
				this.OnPropertyChanged("Address2_Telephone1");
			}
		}
		
		/// <summary>
		/// Type a second phone number associated with the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_telephone2")]
		public string Address2_Telephone2
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_telephone2");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_Telephone2");
				this.SetAttributeValue("address2_telephone2", value);
				this.OnPropertyChanged("Address2_Telephone2");
			}
		}
		
		/// <summary>
		/// Type a third phone number associated with the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_telephone3")]
		public string Address2_Telephone3
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_telephone3");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_Telephone3");
				this.SetAttributeValue("address2_telephone3", value);
				this.OnPropertyChanged("Address2_Telephone3");
			}
		}
		
		/// <summary>
		/// Type the UPS zone of the secondary address to make sure shipping charges are calculated correctly and deliveries are made promptly, if shipped by UPS.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_upszone")]
		public string Address2_UPSZone
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_upszone");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_UPSZone");
				this.SetAttributeValue("address2_upszone", value);
				this.OnPropertyChanged("Address2_UPSZone");
			}
		}
		
		/// <summary>
		/// Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_utcoffset")]
		public System.Nullable<int> Address2_UTCOffset
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("address2_utcoffset");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_UTCOffset");
				this.SetAttributeValue("address2_utcoffset", value);
				this.OnPropertyChanged("Address2_UTCOffset");
			}
		}
		
		/// <summary>
		/// Unique identifier for address 3.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_addressid")]
		public System.Nullable<System.Guid> Address3_AddressId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("address3_addressid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address3_AddressId");
				this.SetAttributeValue("address3_addressid", value);
				this.OnPropertyChanged("Address3_AddressId");
			}
		}
		
		/// <summary>
		/// Select the third address type.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_addresstypecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Address3_AddressTypeCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address3_addresstypecode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address3_AddressTypeCode");
				this.SetAttributeValue("address3_addresstypecode", value);
				this.OnPropertyChanged("Address3_AddressTypeCode");
			}
		}
		
		/// <summary>
		/// Type the city for the 3rd address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_city")]
		public string Address3_City
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address3_city");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address3_City");
				this.SetAttributeValue("address3_city", value);
				this.OnPropertyChanged("Address3_City");
			}
		}
		
		/// <summary>
		/// Shows the complete third address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_composite")]
		public string Address3_Composite
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address3_composite");
			}
		}
		
		/// <summary>
		/// the country or region for the 3rd address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_country")]
		public string Address3_Country
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address3_country");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address3_Country");
				this.SetAttributeValue("address3_country", value);
				this.OnPropertyChanged("Address3_Country");
			}
		}
		
		/// <summary>
		/// Type the county for the third address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_county")]
		public string Address3_County
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address3_county");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address3_County");
				this.SetAttributeValue("address3_county", value);
				this.OnPropertyChanged("Address3_County");
			}
		}
		
		/// <summary>
		/// Type the fax number associated with the third address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_fax")]
		public string Address3_Fax
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address3_fax");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address3_Fax");
				this.SetAttributeValue("address3_fax", value);
				this.OnPropertyChanged("Address3_Fax");
			}
		}
		
		/// <summary>
		/// Select the freight terms for the third address to make sure shipping orders are processed correctly.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_freighttermscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Address3_FreightTermsCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address3_freighttermscode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address3_FreightTermsCode");
				this.SetAttributeValue("address3_freighttermscode", value);
				this.OnPropertyChanged("Address3_FreightTermsCode");
			}
		}
		
		/// <summary>
		/// Type the latitude value for the third address for use in mapping and other applications.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_latitude")]
		public System.Nullable<double> Address3_Latitude
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("address3_latitude");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address3_Latitude");
				this.SetAttributeValue("address3_latitude", value);
				this.OnPropertyChanged("Address3_Latitude");
			}
		}
		
		/// <summary>
		/// the first line of the 3rd address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_line1")]
		public string Address3_Line1
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address3_line1");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address3_Line1");
				this.SetAttributeValue("address3_line1", value);
				this.OnPropertyChanged("Address3_Line1");
			}
		}
		
		/// <summary>
		/// the second line of the 3rd address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_line2")]
		public string Address3_Line2
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address3_line2");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address3_Line2");
				this.SetAttributeValue("address3_line2", value);
				this.OnPropertyChanged("Address3_Line2");
			}
		}
		
		/// <summary>
		/// the third line of the 3rd address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_line3")]
		public string Address3_Line3
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address3_line3");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address3_Line3");
				this.SetAttributeValue("address3_line3", value);
				this.OnPropertyChanged("Address3_Line3");
			}
		}
		
		/// <summary>
		/// Type the longitude value for the third address for use in mapping and other applications.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_longitude")]
		public System.Nullable<double> Address3_Longitude
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("address3_longitude");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address3_Longitude");
				this.SetAttributeValue("address3_longitude", value);
				this.OnPropertyChanged("Address3_Longitude");
			}
		}
		
		/// <summary>
		/// Type a descriptive name for the third address, such as Corporate Headquarters.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_name")]
		public string Address3_Name
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address3_name");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address3_Name");
				this.SetAttributeValue("address3_name", value);
				this.OnPropertyChanged("Address3_Name");
			}
		}
		
		/// <summary>
		/// the ZIP Code or postal code for the 3rd address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_postalcode")]
		public string Address3_PostalCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address3_postalcode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address3_PostalCode");
				this.SetAttributeValue("address3_postalcode", value);
				this.OnPropertyChanged("Address3_PostalCode");
			}
		}
		
		/// <summary>
		/// the post office box number of the 3rd address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_postofficebox")]
		public string Address3_PostOfficeBox
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address3_postofficebox");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address3_PostOfficeBox");
				this.SetAttributeValue("address3_postofficebox", value);
				this.OnPropertyChanged("Address3_PostOfficeBox");
			}
		}
		
		/// <summary>
		/// Type the name of the main contact at the account's third address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_primarycontactname")]
		public string Address3_PrimaryContactName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address3_primarycontactname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address3_PrimaryContactName");
				this.SetAttributeValue("address3_primarycontactname", value);
				this.OnPropertyChanged("Address3_PrimaryContactName");
			}
		}
		
		/// <summary>
		/// Select a shipping method for deliveries sent to this address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_shippingmethodcode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Address3_ShippingMethodCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address3_shippingmethodcode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address3_ShippingMethodCode");
				this.SetAttributeValue("address3_shippingmethodcode", value);
				this.OnPropertyChanged("Address3_ShippingMethodCode");
			}
		}
		
		/// <summary>
		/// the state or province of the third address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_stateorprovince")]
		public string Address3_StateOrProvince
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address3_stateorprovince");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address3_StateOrProvince");
				this.SetAttributeValue("address3_stateorprovince", value);
				this.OnPropertyChanged("Address3_StateOrProvince");
			}
		}
		
		/// <summary>
		/// Type the main phone number associated with the third address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_telephone1")]
		public string Address3_Telephone1
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address3_telephone1");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address3_Telephone1");
				this.SetAttributeValue("address3_telephone1", value);
				this.OnPropertyChanged("Address3_Telephone1");
			}
		}
		
		/// <summary>
		/// Type a second phone number associated with the third address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_telephone2")]
		public string Address3_Telephone2
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address3_telephone2");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address3_Telephone2");
				this.SetAttributeValue("address3_telephone2", value);
				this.OnPropertyChanged("Address3_Telephone2");
			}
		}
		
		/// <summary>
		/// Type a third phone number associated with the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_telephone3")]
		public string Address3_Telephone3
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address3_telephone3");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address3_Telephone3");
				this.SetAttributeValue("address3_telephone3", value);
				this.OnPropertyChanged("Address3_Telephone3");
			}
		}
		
		/// <summary>
		/// Type the UPS zone of the third address to make sure shipping charges are calculated correctly and deliveries are made promptly, if shipped by UPS.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_upszone")]
		public string Address3_UPSZone
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address3_upszone");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address3_UPSZone");
				this.SetAttributeValue("address3_upszone", value);
				this.OnPropertyChanged("Address3_UPSZone");
			}
		}
		
		/// <summary>
		/// Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_utcoffset")]
		public System.Nullable<int> Address3_UTCOffset
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("address3_utcoffset");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address3_UTCOffset");
				this.SetAttributeValue("address3_utcoffset", value);
				this.OnPropertyChanged("Address3_UTCOffset");
			}
		}
		
		/// <summary>
		/// Partner Competencies
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_competencies")]
		public string adx_Competencies
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("adx_competencies");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_Competencies");
				this.SetAttributeValue("adx_competencies", value);
				this.OnPropertyChanged("adx_Competencies");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_confirmremovepassword")]
		public System.Nullable<bool> adx_ConfirmRemovePassword
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("adx_confirmremovepassword");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_ConfirmRemovePassword");
				this.SetAttributeValue("adx_confirmremovepassword", value);
				this.OnPropertyChanged("adx_ConfirmRemovePassword");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_createdbyipaddress")]
		public string Adx_CreatedByIPAddress
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("adx_createdbyipaddress");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Adx_CreatedByIPAddress");
				this.SetAttributeValue("adx_createdbyipaddress", value);
				this.OnPropertyChanged("Adx_CreatedByIPAddress");
			}
		}
		
		/// <summary>
		/// Unique identifier for Contact associated with Contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_createdbyportalcontactid")]
		public Microsoft.Xrm.Sdk.EntityReference adx_createdbyportalcontactId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("adx_createdbyportalcontactid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_createdbyportalcontactId");
				this.SetAttributeValue("adx_createdbyportalcontactid", value);
				this.OnPropertyChanged("adx_createdbyportalcontactId");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_createdbyusername")]
		public string Adx_CreatedByUsername
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("adx_createdbyusername");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Adx_CreatedByUsername");
				this.SetAttributeValue("adx_createdbyusername", value);
				this.OnPropertyChanged("Adx_CreatedByUsername");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_geo_apac")]
		public System.Nullable<bool> adx_geo_apac
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("adx_geo_apac");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_geo_apac");
				this.SetAttributeValue("adx_geo_apac", value);
				this.OnPropertyChanged("adx_geo_apac");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_geo_australia")]
		public System.Nullable<bool> adx_geo_australia
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("adx_geo_australia");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_geo_australia");
				this.SetAttributeValue("adx_geo_australia", value);
				this.OnPropertyChanged("adx_geo_australia");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_geo_emea")]
		public System.Nullable<bool> adx_geo_emea
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("adx_geo_emea");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_geo_emea");
				this.SetAttributeValue("adx_geo_emea", value);
				this.OnPropertyChanged("adx_geo_emea");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_geo_northamerica")]
		public System.Nullable<bool> adx_geo_northamerica
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("adx_geo_northamerica");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_geo_northamerica");
				this.SetAttributeValue("adx_geo_northamerica", value);
				this.OnPropertyChanged("adx_geo_northamerica");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_geo_southamerica")]
		public System.Nullable<bool> adx_geo_southamerica
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("adx_geo_southamerica");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_geo_southamerica");
				this.SetAttributeValue("adx_geo_southamerica", value);
				this.OnPropertyChanged("adx_geo_southamerica");
			}
		}
		
		/// <summary>
		/// Shows the current count of failed password attempts for the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_identity_accessfailedcount")]
		public System.Nullable<int> adx_identity_accessfailedcount
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("adx_identity_accessfailedcount");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_identity_accessfailedcount");
				this.SetAttributeValue("adx_identity_accessfailedcount", value);
				this.OnPropertyChanged("adx_identity_accessfailedcount");
			}
		}
		
		/// <summary>
		/// Determines if the email is confirmed by the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_identity_emailaddress1confirmed")]
		public System.Nullable<bool> adx_identity_emailaddress1confirmed
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("adx_identity_emailaddress1confirmed");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_identity_emailaddress1confirmed");
				this.SetAttributeValue("adx_identity_emailaddress1confirmed", value);
				this.OnPropertyChanged("adx_identity_emailaddress1confirmed");
			}
		}
		
		/// <summary>
		/// Indicates the last date and time the user successfully signed in to a portal.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_identity_lastsuccessfullogin")]
		public System.Nullable<System.DateTime> adx_identity_lastsuccessfullogin
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("adx_identity_lastsuccessfullogin");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_identity_lastsuccessfullogin");
				this.SetAttributeValue("adx_identity_lastsuccessfullogin", value);
				this.OnPropertyChanged("adx_identity_lastsuccessfullogin");
			}
		}
		
		/// <summary>
		/// Indicates that the contact can no longer sign in to the portal using the local account.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_identity_locallogindisabled")]
		public System.Nullable<bool> adx_identity_locallogindisabled
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("adx_identity_locallogindisabled");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_identity_locallogindisabled");
				this.SetAttributeValue("adx_identity_locallogindisabled", value);
				this.OnPropertyChanged("adx_identity_locallogindisabled");
			}
		}
		
		/// <summary>
		/// Determines if this contact will track failed access attempts and become locked after too many failed attempts. To prevent the contact from becoming locked, you can disable this setting.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_identity_lockoutenabled")]
		public System.Nullable<bool> adx_identity_lockoutenabled
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("adx_identity_lockoutenabled");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_identity_lockoutenabled");
				this.SetAttributeValue("adx_identity_lockoutenabled", value);
				this.OnPropertyChanged("adx_identity_lockoutenabled");
			}
		}
		
		/// <summary>
		/// Shows the moment in time when the locked contact becomes unlocked again.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_identity_lockoutenddate")]
		public System.Nullable<System.DateTime> adx_identity_lockoutenddate
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("adx_identity_lockoutenddate");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_identity_lockoutenddate");
				this.SetAttributeValue("adx_identity_lockoutenddate", value);
				this.OnPropertyChanged("adx_identity_lockoutenddate");
			}
		}
		
		/// <summary>
		/// Determines if web authentication is enabled for the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_identity_logonenabled")]
		public System.Nullable<bool> adx_identity_logonenabled
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("adx_identity_logonenabled");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_identity_logonenabled");
				this.SetAttributeValue("adx_identity_logonenabled", value);
				this.OnPropertyChanged("adx_identity_logonenabled");
			}
		}
		
		/// <summary>
		/// Determines if the phone number is confirmed by the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_identity_mobilephoneconfirmed")]
		public System.Nullable<bool> adx_identity_mobilephoneconfirmed
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("adx_identity_mobilephoneconfirmed");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_identity_mobilephoneconfirmed");
				this.SetAttributeValue("adx_identity_mobilephoneconfirmed", value);
				this.OnPropertyChanged("adx_identity_mobilephoneconfirmed");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_identity_newpassword")]
		public string adx_identity_newpassword
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("adx_identity_newpassword");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_identity_newpassword");
				this.SetAttributeValue("adx_identity_newpassword", value);
				this.OnPropertyChanged("adx_identity_newpassword");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_identity_passwordhash")]
		public string adx_identity_passwordhash
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("adx_identity_passwordhash");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_identity_passwordhash");
				this.SetAttributeValue("adx_identity_passwordhash", value);
				this.OnPropertyChanged("adx_identity_passwordhash");
			}
		}
		
		/// <summary>
		/// A token used to manage the web authentication session.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_identity_securitystamp")]
		public string adx_identity_securitystamp
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("adx_identity_securitystamp");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_identity_securitystamp");
				this.SetAttributeValue("adx_identity_securitystamp", value);
				this.OnPropertyChanged("adx_identity_securitystamp");
			}
		}
		
		/// <summary>
		/// Determines if two-factor authentication is enabled for the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_identity_twofactorenabled")]
		public System.Nullable<bool> adx_identity_twofactorenabled
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("adx_identity_twofactorenabled");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_identity_twofactorenabled");
				this.SetAttributeValue("adx_identity_twofactorenabled", value);
				this.OnPropertyChanged("adx_identity_twofactorenabled");
			}
		}
		
		/// <summary>
		/// Shows the user identity for local web authentication.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_identity_username")]
		public string adx_identity_username
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("adx_identity_username");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_identity_username");
				this.SetAttributeValue("adx_identity_username", value);
				this.OnPropertyChanged("adx_identity_username");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_interestedinpartnerenrollment")]
		public System.Nullable<bool> adx_Interestedinpartnerenrollment
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("adx_interestedinpartnerenrollment");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_Interestedinpartnerenrollment");
				this.SetAttributeValue("adx_interestedinpartnerenrollment", value);
				this.OnPropertyChanged("adx_Interestedinpartnerenrollment");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_modifiedbyipaddress")]
		public string Adx_ModifiedByIPAddress
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("adx_modifiedbyipaddress");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Adx_ModifiedByIPAddress");
				this.SetAttributeValue("adx_modifiedbyipaddress", value);
				this.OnPropertyChanged("Adx_ModifiedByIPAddress");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_modifiedbyusername")]
		public string Adx_ModifiedByUsername
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("adx_modifiedbyusername");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Adx_ModifiedByUsername");
				this.SetAttributeValue("adx_modifiedbyusername", value);
				this.OnPropertyChanged("Adx_ModifiedByUsername");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_organizationname")]
		public string Adx_OrganizationName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("adx_organizationname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Adx_OrganizationName");
				this.SetAttributeValue("adx_organizationname", value);
				this.OnPropertyChanged("Adx_OrganizationName");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_partner_accountcreated")]
		public System.Nullable<bool> adx_partner_accountcreated
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("adx_partner_accountcreated");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_partner_accountcreated");
				this.SetAttributeValue("adx_partner_accountcreated", value);
				this.OnPropertyChanged("adx_partner_accountcreated");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_partner_anniversarydate")]
		public System.Nullable<System.DateTime> adx_partner_anniversarydate
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("adx_partner_anniversarydate");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_partner_anniversarydate");
				this.SetAttributeValue("adx_partner_anniversarydate", value);
				this.OnPropertyChanged("adx_partner_anniversarydate");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_partner_applicationdate")]
		public System.Nullable<System.DateTime> adx_partner_applicationdate
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("adx_partner_applicationdate");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_partner_applicationdate");
				this.SetAttributeValue("adx_partner_applicationdate", value);
				this.OnPropertyChanged("adx_partner_applicationdate");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_partner_applicationstatus")]
		public Microsoft.Xrm.Sdk.OptionSetValue adx_partner_applicationstatus
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("adx_partner_applicationstatus");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_partner_applicationstatus");
				this.SetAttributeValue("adx_partner_applicationstatus", value);
				this.OnPropertyChanged("adx_partner_applicationstatus");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_partner_applicationsubmitted")]
		public System.Nullable<bool> adx_partner_applicationsubmitted
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("adx_partner_applicationsubmitted");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_partner_applicationsubmitted");
				this.SetAttributeValue("adx_partner_applicationsubmitted", value);
				this.OnPropertyChanged("adx_partner_applicationsubmitted");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_partner_targetmarket")]
		public string adx_partner_targetmarket
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("adx_partner_targetmarket");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_partner_targetmarket");
				this.SetAttributeValue("adx_partner_targetmarket", value);
				this.OnPropertyChanged("adx_partner_targetmarket");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_partner_technologies")]
		public string adx_partner_technologies
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("adx_partner_technologies");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_partner_technologies");
				this.SetAttributeValue("adx_partner_technologies", value);
				this.OnPropertyChanged("adx_partner_technologies");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_partnercontactrole")]
		public Microsoft.Xrm.Sdk.OptionSetValue adx_PartnerContactRole
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("adx_partnercontactrole");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_PartnerContactRole");
				this.SetAttributeValue("adx_partnercontactrole", value);
				this.OnPropertyChanged("adx_PartnerContactRole");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_partnerkeyreferences")]
		public string adx_PartnerKeyReferences
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("adx_partnerkeyreferences");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_PartnerKeyReferences");
				this.SetAttributeValue("adx_partnerkeyreferences", value);
				this.OnPropertyChanged("adx_PartnerKeyReferences");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_partnernumberofemployees")]
		public System.Nullable<int> adx_PartnerNumberOfEmployees
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("adx_partnernumberofemployees");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_PartnerNumberOfEmployees");
				this.SetAttributeValue("adx_partnernumberofemployees", value);
				this.OnPropertyChanged("adx_PartnerNumberOfEmployees");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_partneryearsofrelevantexperience")]
		public System.Nullable<decimal> adx_PartnerYearsofRelevantExperience
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("adx_partneryearsofrelevantexperience");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_PartnerYearsofRelevantExperience");
				this.SetAttributeValue("adx_partneryearsofrelevantexperience", value);
				this.OnPropertyChanged("adx_PartnerYearsofRelevantExperience");
			}
		}
		
		/// <summary>
		/// User’s preferred portal language
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_preferredlanguageid")]
		public Microsoft.Xrm.Sdk.EntityReference adx_preferredlanguageid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("adx_preferredlanguageid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_preferredlanguageid");
				this.SetAttributeValue("adx_preferredlanguageid", value);
				this.OnPropertyChanged("adx_preferredlanguageid");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_profilealert")]
		public System.Nullable<bool> adx_profilealert
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("adx_profilealert");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_profilealert");
				this.SetAttributeValue("adx_profilealert", value);
				this.OnPropertyChanged("adx_profilealert");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_profilealertdate")]
		public System.Nullable<System.DateTime> adx_profilealertdate
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("adx_profilealertdate");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_profilealertdate");
				this.SetAttributeValue("adx_profilealertdate", value);
				this.OnPropertyChanged("adx_profilealertdate");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_profilealertinstructions")]
		public string adx_profilealertinstructions
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("adx_profilealertinstructions");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_profilealertinstructions");
				this.SetAttributeValue("adx_profilealertinstructions", value);
				this.OnPropertyChanged("adx_profilealertinstructions");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_profileisanonymous")]
		public System.Nullable<bool> Adx_ProfileIsAnonymous
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("adx_profileisanonymous");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Adx_ProfileIsAnonymous");
				this.SetAttributeValue("adx_profileisanonymous", value);
				this.OnPropertyChanged("Adx_ProfileIsAnonymous");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_profilelastactivity")]
		public System.Nullable<System.DateTime> Adx_ProfileLastActivity
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("adx_profilelastactivity");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Adx_ProfileLastActivity");
				this.SetAttributeValue("adx_profilelastactivity", value);
				this.OnPropertyChanged("Adx_ProfileLastActivity");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_profilemodifiedon")]
		public System.Nullable<System.DateTime> adx_profilemodifiedon
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("adx_profilemodifiedon");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_profilemodifiedon");
				this.SetAttributeValue("adx_profilemodifiedon", value);
				this.OnPropertyChanged("adx_profilemodifiedon");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_publicprofilecopy")]
		public string adx_PublicProfileCopy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("adx_publicprofilecopy");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_PublicProfileCopy");
				this.SetAttributeValue("adx_publicprofilecopy", value);
				this.OnPropertyChanged("adx_PublicProfileCopy");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_timezone")]
		public System.Nullable<int> Adx_TimeZone
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("adx_timezone");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Adx_TimeZone");
				this.SetAttributeValue("adx_timezone", value);
				this.OnPropertyChanged("Adx_TimeZone");
			}
		}
		
		/// <summary>
		/// For system use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging30")]
		public Microsoft.Xrm.Sdk.Money Aging30
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging30");
			}
		}
		
		/// <summary>
		/// Shows the Aging 30 field converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging30_base")]
		public Microsoft.Xrm.Sdk.Money Aging30_Base
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging30_base");
			}
		}
		
		/// <summary>
		/// For system use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging60")]
		public Microsoft.Xrm.Sdk.Money Aging60
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging60");
			}
		}
		
		/// <summary>
		/// Shows the Aging 60 field converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging60_base")]
		public Microsoft.Xrm.Sdk.Money Aging60_Base
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging60_base");
			}
		}
		
		/// <summary>
		/// For system use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging90")]
		public Microsoft.Xrm.Sdk.Money Aging90
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging90");
			}
		}
		
		/// <summary>
		/// Shows the Aging 90 field converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging90_base")]
		public Microsoft.Xrm.Sdk.Money Aging90_Base
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging90_base");
			}
		}
		
		/// <summary>
		/// Enter the date of the contact's wedding or service anniversary for use in customer gift programs or other communications.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("anniversary")]
		public System.Nullable<System.DateTime> Anniversary
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("anniversary");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Anniversary");
				this.SetAttributeValue("anniversary", value);
				this.OnPropertyChanged("Anniversary");
			}
		}
		
		/// <summary>
		/// Type the contact's annual income for use in profiling and financial analysis.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("annualincome")]
		public Microsoft.Xrm.Sdk.Money AnnualIncome
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("annualincome");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("AnnualIncome");
				this.SetAttributeValue("annualincome", value);
				this.OnPropertyChanged("AnnualIncome");
			}
		}
		
		/// <summary>
		/// Shows the Annual Income field converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("annualincome_base")]
		public Microsoft.Xrm.Sdk.Money AnnualIncome_Base
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("annualincome_base");
			}
		}
		
		/// <summary>
		/// Type the name of the contact's assistant.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("assistantname")]
		public string AssistantName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("assistantname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("AssistantName");
				this.SetAttributeValue("assistantname", value);
				this.OnPropertyChanged("AssistantName");
			}
		}
		
		/// <summary>
		/// Type the phone number for the contact's assistant.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("assistantphone")]
		public string AssistantPhone
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("assistantphone");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("AssistantPhone");
				this.SetAttributeValue("assistantphone", value);
				this.OnPropertyChanged("AssistantPhone");
			}
		}
		
		/// <summary>
		/// Enter the contact's birthday for use in customer gift programs or other communications.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("birthdate")]
		public System.Nullable<System.DateTime> BirthDate
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("birthdate");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("BirthDate");
				this.SetAttributeValue("birthdate", value);
				this.OnPropertyChanged("BirthDate");
			}
		}
		
		/// <summary>
		/// Type a second business phone number for this contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("business2")]
		public string Business2
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("business2");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Business2");
				this.SetAttributeValue("business2", value);
				this.OnPropertyChanged("Business2");
			}
		}
		
		/// <summary>
		/// Stores Image of the Business Card
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businesscard")]
		public string BusinessCard
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("businesscard");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("BusinessCard");
				this.SetAttributeValue("businesscard", value);
				this.OnPropertyChanged("BusinessCard");
			}
		}
		
		/// <summary>
		/// Stores Business Card Control Properties.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businesscardattributes")]
		public string BusinessCardAttributes
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("businesscardattributes");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("BusinessCardAttributes");
				this.SetAttributeValue("businesscardattributes", value);
				this.OnPropertyChanged("BusinessCardAttributes");
			}
		}
		
		/// <summary>
		/// Type a callback phone number for this contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("callback")]
		public string Callback
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("callback");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Callback");
				this.SetAttributeValue("callback", value);
				this.OnPropertyChanged("Callback");
			}
		}
		
		/// <summary>
		/// Type the names of the contact's children for reference in communications and client programs.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("childrensnames")]
		public string ChildrensNames
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("childrensnames");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ChildrensNames");
				this.SetAttributeValue("childrensnames", value);
				this.OnPropertyChanged("ChildrensNames");
			}
		}
		
		/// <summary>
		/// Type the company phone of the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("company")]
		public string Company
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("company");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Company");
				this.SetAttributeValue("company", value);
				this.OnPropertyChanged("Company");
			}
		}
		
		/// <summary>
		/// Unique identifier of the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contactid")]
		public System.Nullable<System.Guid> ContactId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("contactid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ContactId");
				this.SetAttributeValue("contactid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("ContactId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contactid")]
		public override System.Guid Id
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return base.Id;
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.ContactId = value;
			}
		}
		
		/// <summary>
		/// Shows who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Shows the external party who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdbyexternalparty")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedByExternalParty
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdbyexternalparty");
			}
		}
		
		/// <summary>
		/// Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Shows who created the record on behalf of another user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CreatedOnBehalfBy");
				this.SetAttributeValue("createdonbehalfby", value);
				this.OnPropertyChanged("CreatedOnBehalfBy");
			}
		}
		
		/// <summary>
		/// Type the credit limit of the contact for reference when you address invoice and accounting issues with the customer.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("creditlimit")]
		public Microsoft.Xrm.Sdk.Money CreditLimit
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("creditlimit");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CreditLimit");
				this.SetAttributeValue("creditlimit", value);
				this.OnPropertyChanged("CreditLimit");
			}
		}
		
		/// <summary>
		/// Shows the Credit Limit field converted to the system's default base currency for reporting purposes. The calculations use the exchange rate specified in the Currencies area.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("creditlimit_base")]
		public Microsoft.Xrm.Sdk.Money CreditLimit_Base
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("creditlimit_base");
			}
		}
		
		/// <summary>
		/// Select whether the contact is on a credit hold, for reference when addressing invoice and accounting issues.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("creditonhold")]
		public System.Nullable<bool> CreditOnHold
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("creditonhold");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CreditOnHold");
				this.SetAttributeValue("creditonhold", value);
				this.OnPropertyChanged("CreditOnHold");
			}
		}
		
		/// <summary>
		/// Select the size of the contact's company for segmentation and reporting purposes.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customersizecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue CustomerSizeCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("customersizecode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CustomerSizeCode");
				this.SetAttributeValue("customersizecode", value);
				this.OnPropertyChanged("CustomerSizeCode");
			}
		}
		
		/// <summary>
		/// Select the category that best describes the relationship between the contact and your organization.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customertypecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue CustomerTypeCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("customertypecode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CustomerTypeCode");
				this.SetAttributeValue("customertypecode", value);
				this.OnPropertyChanged("CustomerTypeCode");
			}
		}
		
		/// <summary>
		/// Choose the default price list associated with the contact to make sure the correct product prices for this customer are applied in sales opportunities, quotes, and orders.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("defaultpricelevelid")]
		public Microsoft.Xrm.Sdk.EntityReference DefaultPriceLevelId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("defaultpricelevelid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DefaultPriceLevelId");
				this.SetAttributeValue("defaultpricelevelid", value);
				this.OnPropertyChanged("DefaultPriceLevelId");
			}
		}
		
		/// <summary>
		/// Type the department or business unit where the contact works in the parent company or business.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("department")]
		public string Department
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("department");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Department");
				this.SetAttributeValue("department", value);
				this.OnPropertyChanged("Department");
			}
		}
		
		/// <summary>
		/// Type additional information to describe the contact, such as an excerpt from the company's website.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("description")]
		public string Description
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("description");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Description");
				this.SetAttributeValue("description", value);
				this.OnPropertyChanged("Description");
			}
		}
		
		/// <summary>
		/// Select whether the contact accepts bulk email sent through marketing campaigns or quick campaigns. If Do Not Allow is selected, the contact can be added to marketing lists, but will be excluded from the email.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotbulkemail")]
		public System.Nullable<bool> DoNotBulkEMail
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotbulkemail");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DoNotBulkEMail");
				this.SetAttributeValue("donotbulkemail", value);
				this.OnPropertyChanged("DoNotBulkEMail");
			}
		}
		
		/// <summary>
		/// Select whether the contact accepts bulk postal mail sent through marketing campaigns or quick campaigns. If Do Not Allow is selected, the contact can be added to marketing lists, but will be excluded from the letters.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotbulkpostalmail")]
		public System.Nullable<bool> DoNotBulkPostalMail
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotbulkpostalmail");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DoNotBulkPostalMail");
				this.SetAttributeValue("donotbulkpostalmail", value);
				this.OnPropertyChanged("DoNotBulkPostalMail");
			}
		}
		
		/// <summary>
		/// Select whether the contact allows direct email sent from Microsoft Dynamics 365. If Do Not Allow is selected, Microsoft Dynamics 365 will not send the email.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotemail")]
		public System.Nullable<bool> DoNotEMail
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotemail");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DoNotEMail");
				this.SetAttributeValue("donotemail", value);
				this.OnPropertyChanged("DoNotEMail");
			}
		}
		
		/// <summary>
		/// Select whether the contact allows faxes. If Do Not Allow is selected, the contact will be excluded from any fax activities distributed in marketing campaigns.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotfax")]
		public System.Nullable<bool> DoNotFax
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotfax");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DoNotFax");
				this.SetAttributeValue("donotfax", value);
				this.OnPropertyChanged("DoNotFax");
			}
		}
		
		/// <summary>
		/// Select whether the contact accepts phone calls. If Do Not Allow is selected, the contact will be excluded from any phone call activities distributed in marketing campaigns.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotphone")]
		public System.Nullable<bool> DoNotPhone
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotphone");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DoNotPhone");
				this.SetAttributeValue("donotphone", value);
				this.OnPropertyChanged("DoNotPhone");
			}
		}
		
		/// <summary>
		/// Select whether the contact allows direct mail. If Do Not Allow is selected, the contact will be excluded from letter activities distributed in marketing campaigns.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotpostalmail")]
		public System.Nullable<bool> DoNotPostalMail
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotpostalmail");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DoNotPostalMail");
				this.SetAttributeValue("donotpostalmail", value);
				this.OnPropertyChanged("DoNotPostalMail");
			}
		}
		
		/// <summary>
		/// Select whether the contact accepts marketing materials, such as brochures or catalogs. Contacts that opt out can be excluded from marketing initiatives.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotsendmm")]
		public System.Nullable<bool> DoNotSendMM
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotsendmm");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DoNotSendMM");
				this.SetAttributeValue("donotsendmm", value);
				this.OnPropertyChanged("DoNotSendMM");
			}
		}
		
		/// <summary>
		/// Select the contact's highest level of education for use in segmentation and analysis.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("educationcode")]
		public Microsoft.Xrm.Sdk.OptionSetValue EducationCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("educationcode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("EducationCode");
				this.SetAttributeValue("educationcode", value);
				this.OnPropertyChanged("EducationCode");
			}
		}
		
		/// <summary>
		/// Type the primary email address for the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailaddress1")]
		public string EMailAddress1
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("emailaddress1");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("EMailAddress1");
				this.SetAttributeValue("emailaddress1", value);
				this.OnPropertyChanged("EMailAddress1");
			}
		}
		
		/// <summary>
		/// Type the secondary email address for the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailaddress2")]
		public string EMailAddress2
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("emailaddress2");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("EMailAddress2");
				this.SetAttributeValue("emailaddress2", value);
				this.OnPropertyChanged("EMailAddress2");
			}
		}
		
		/// <summary>
		/// Type an alternate email address for the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailaddress3")]
		public string EMailAddress3
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("emailaddress3");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("EMailAddress3");
				this.SetAttributeValue("emailaddress3", value);
				this.OnPropertyChanged("EMailAddress3");
			}
		}
		
		/// <summary>
		/// Type the employee ID or number for the contact for reference in orders, service cases, or other communications with the contact's organization.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("employeeid")]
		public string EmployeeId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("employeeid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("EmployeeId");
				this.SetAttributeValue("employeeid", value);
				this.OnPropertyChanged("EmployeeId");
			}
		}
		
		/// <summary>
		/// Shows the default image for the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage")]
		public byte[] EntityImage
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<byte[]>("entityimage");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("EntityImage");
				this.SetAttributeValue("entityimage", value);
				this.OnPropertyChanged("EntityImage");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage_timestamp")]
		public System.Nullable<long> EntityImage_Timestamp
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("entityimage_timestamp");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage_url")]
		public string EntityImage_URL
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("entityimage_url");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimageid")]
		public System.Nullable<System.Guid> EntityImageId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("entityimageid");
			}
		}
		
		/// <summary>
		/// Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
		public System.Nullable<decimal> ExchangeRate
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate");
			}
		}
		
		/// <summary>
		/// Identifier for an external user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("externaluseridentifier")]
		public string ExternalUserIdentifier
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("externaluseridentifier");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ExternalUserIdentifier");
				this.SetAttributeValue("externaluseridentifier", value);
				this.OnPropertyChanged("ExternalUserIdentifier");
			}
		}
		
		/// <summary>
		/// Select the marital status of the contact for reference in follow-up phone calls and other communications.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("familystatuscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue FamilyStatusCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("familystatuscode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("FamilyStatusCode");
				this.SetAttributeValue("familystatuscode", value);
				this.OnPropertyChanged("FamilyStatusCode");
			}
		}
		
		/// <summary>
		/// Type the fax number for the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fax")]
		public string Fax
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("fax");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Fax");
				this.SetAttributeValue("fax", value);
				this.OnPropertyChanged("Fax");
			}
		}
		
		/// <summary>
		/// Type the contact's first name to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("firstname")]
		public string FirstName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("firstname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("FirstName");
				this.SetAttributeValue("firstname", value);
				this.OnPropertyChanged("FirstName");
			}
		}
		
		/// <summary>
		/// Information about whether to allow following email activity like opens, attachment views and link clicks for emails sent to the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("followemail")]
		public System.Nullable<bool> FollowEmail
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("followemail");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("FollowEmail");
				this.SetAttributeValue("followemail", value);
				this.OnPropertyChanged("FollowEmail");
			}
		}
		
		/// <summary>
		/// Type the URL for the contact's FTP site to enable users to access data and share documents.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ftpsiteurl")]
		public string FtpSiteUrl
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("ftpsiteurl");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("FtpSiteUrl");
				this.SetAttributeValue("ftpsiteurl", value);
				this.OnPropertyChanged("FtpSiteUrl");
			}
		}
		
		/// <summary>
		/// Combines and shows the contact's first and last names so that the full name can be displayed in views and reports.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fullname")]
		public string FullName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("fullname");
			}
		}
		
		/// <summary>
		/// Select the contact's gender to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("gendercode")]
		public Microsoft.Xrm.Sdk.OptionSetValue GenderCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("gendercode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("GenderCode");
				this.SetAttributeValue("gendercode", value);
				this.OnPropertyChanged("GenderCode");
			}
		}
		
		/// <summary>
		/// Type the passport number or other government ID for the contact for use in documents or reports.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("governmentid")]
		public string GovernmentId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("governmentid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("GovernmentId");
				this.SetAttributeValue("governmentid", value);
				this.OnPropertyChanged("GovernmentId");
			}
		}
		
		/// <summary>
		/// Select whether the contact has any children for reference in follow-up phone calls and other communications.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("haschildrencode")]
		public Microsoft.Xrm.Sdk.OptionSetValue HasChildrenCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("haschildrencode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("HasChildrenCode");
				this.SetAttributeValue("haschildrencode", value);
				this.OnPropertyChanged("HasChildrenCode");
			}
		}
		
		/// <summary>
		/// Type a second home phone number for this contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("home2")]
		public string Home2
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("home2");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Home2");
				this.SetAttributeValue("home2", value);
				this.OnPropertyChanged("Home2");
			}
		}
		
		/// <summary>
		/// Unique identifier of the data import or data migration that created this record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
		public System.Nullable<int> ImportSequenceNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ImportSequenceNumber");
				this.SetAttributeValue("importsequencenumber", value);
				this.OnPropertyChanged("ImportSequenceNumber");
			}
		}
		
		/// <summary>
		/// Select whether the contact exists in a separate accounting or other system, such as Microsoft Dynamics GP or another ERP database, for use in integration processes.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isbackofficecustomer")]
		public System.Nullable<bool> IsBackofficeCustomer
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isbackofficecustomer");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsBackofficeCustomer");
				this.SetAttributeValue("isbackofficecustomer", value);
				this.OnPropertyChanged("IsBackofficeCustomer");
			}
		}
		
		/// <summary>
		/// Type the job title of the contact to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("jobtitle")]
		public string JobTitle
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("jobtitle");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("JobTitle");
				this.SetAttributeValue("jobtitle", value);
				this.OnPropertyChanged("JobTitle");
			}
		}
		
		/// <summary>
		/// Type the contact's last name to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastname")]
		public string LastName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("lastname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("LastName");
				this.SetAttributeValue("lastname", value);
				this.OnPropertyChanged("LastName");
			}
		}
		
		/// <summary>
		/// Contains the date and time stamp of the last on hold time.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastonholdtime")]
		public System.Nullable<System.DateTime> LastOnHoldTime
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("lastonholdtime");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("LastOnHoldTime");
				this.SetAttributeValue("lastonholdtime", value);
				this.OnPropertyChanged("LastOnHoldTime");
			}
		}
		
		/// <summary>
		/// Shows the date when the contact was last included in a marketing campaign or quick campaign.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastusedincampaign")]
		public System.Nullable<System.DateTime> LastUsedInCampaign
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("lastusedincampaign");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("LastUsedInCampaign");
				this.SetAttributeValue("lastusedincampaign", value);
				this.OnPropertyChanged("LastUsedInCampaign");
			}
		}
		
		/// <summary>
		/// Select the primary marketing source that directed the contact to your organization.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("leadsourcecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue LeadSourceCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("leadsourcecode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("LeadSourceCode");
				this.SetAttributeValue("leadsourcecode", value);
				this.OnPropertyChanged("LeadSourceCode");
			}
		}
		
		/// <summary>
		/// Used internally to track the unique linkedin id of the contact record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("li_companyid")]
		public System.Nullable<int> li_CompanyId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("li_companyid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("li_CompanyId");
				this.SetAttributeValue("li_companyid", value);
				this.OnPropertyChanged("li_CompanyId");
			}
		}
		
		/// <summary>
		/// Used internally to track the unique linkedin id of the contact record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("li_membertoken")]
		public string li_MemberToken
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("li_membertoken");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("li_MemberToken");
				this.SetAttributeValue("li_membertoken", value);
				this.OnPropertyChanged("li_MemberToken");
			}
		}
		
		/// <summary>
		/// Type the name of the contact's manager for use in escalating issues or other follow-up communications with the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("managername")]
		public string ManagerName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("managername");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ManagerName");
				this.SetAttributeValue("managername", value);
				this.OnPropertyChanged("ManagerName");
			}
		}
		
		/// <summary>
		/// Type the phone number for the contact's manager.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("managerphone")]
		public string ManagerPhone
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("managerphone");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ManagerPhone");
				this.SetAttributeValue("managerphone", value);
				this.OnPropertyChanged("ManagerPhone");
			}
		}
		
		/// <summary>
		/// Whether is only for marketing
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("marketingonly")]
		public System.Nullable<bool> MarketingOnly
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("marketingonly");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("MarketingOnly");
				this.SetAttributeValue("marketingonly", value);
				this.OnPropertyChanged("MarketingOnly");
			}
		}
		
		/// <summary>
		/// Unique identifier of the master contact for merge.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("masterid")]
		public Microsoft.Xrm.Sdk.EntityReference MasterId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("masterid");
			}
		}
		
		/// <summary>
		/// Shows whether the account has been merged with a master contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("merged")]
		public System.Nullable<bool> Merged
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("merged");
			}
		}
		
		/// <summary>
		/// Type the contact's middle name or initial to make sure the contact is addressed correctly.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("middlename")]
		public string MiddleName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("middlename");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("MiddleName");
				this.SetAttributeValue("middlename", value);
				this.OnPropertyChanged("MiddleName");
			}
		}
		
		/// <summary>
		/// Type the mobile phone number for the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mobilephone")]
		public string MobilePhone
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("mobilephone");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("MobilePhone");
				this.SetAttributeValue("mobilephone", value);
				this.OnPropertyChanged("MobilePhone");
			}
		}
		
		/// <summary>
		/// Shows who last updated the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Shows the external party who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedbyexternalparty")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedByExternalParty
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedbyexternalparty");
			}
		}
		
		/// <summary>
		/// Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Shows who last updated the record on behalf of another user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ModifiedOnBehalfBy");
				this.SetAttributeValue("modifiedonbehalfby", value);
				this.OnPropertyChanged("ModifiedOnBehalfBy");
			}
		}
		
		/// <summary>
		/// Unique identifier for Account associated with Contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msa_managingpartnerid")]
		public Microsoft.Xrm.Sdk.EntityReference msa_managingpartnerid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("msa_managingpartnerid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msa_managingpartnerid");
				this.SetAttributeValue("msa_managingpartnerid", value);
				this.OnPropertyChanged("msa_managingpartnerid");
			}
		}
		
		/// <summary>
		/// Maps to contact KPI records
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_contactkpiid")]
		public Microsoft.Xrm.Sdk.EntityReference msdyn_contactkpiid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("msdyn_contactkpiid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_contactkpiid");
				this.SetAttributeValue("msdyn_contactkpiid", value);
				this.OnPropertyChanged("msdyn_contactkpiid");
			}
		}
		
		/// <summary>
		/// Indicates that the contact has opted out of web tracking.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_disablewebtracking")]
		public System.Nullable<bool> msdyn_disablewebtracking
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("msdyn_disablewebtracking");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_disablewebtracking");
				this.SetAttributeValue("msdyn_disablewebtracking", value);
				this.OnPropertyChanged("msdyn_disablewebtracking");
			}
		}
		
		/// <summary>
		/// Describes whether contact is opted out or not
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_gdproptout")]
		public System.Nullable<bool> msdyn_gdproptout
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("msdyn_gdproptout");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_gdproptout");
				this.SetAttributeValue("msdyn_gdproptout", value);
				this.OnPropertyChanged("msdyn_gdproptout");
			}
		}
		
		/// <summary>
		/// Indicates that the contact is considered a minor in their jurisdiction.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_isminor")]
		public System.Nullable<bool> msdyn_isminor
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("msdyn_isminor");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_isminor");
				this.SetAttributeValue("msdyn_isminor", value);
				this.OnPropertyChanged("msdyn_isminor");
			}
		}
		
		/// <summary>
		/// Indicates that the contact is considered a minor in their jurisdiction and has parental consent.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_isminorwithparentalconsent")]
		public System.Nullable<bool> msdyn_isminorwithparentalconsent
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("msdyn_isminorwithparentalconsent");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_isminorwithparentalconsent");
				this.SetAttributeValue("msdyn_isminorwithparentalconsent", value);
				this.OnPropertyChanged("msdyn_isminorwithparentalconsent");
			}
		}
		
		/// <summary>
		/// Whether or not the contact belongs to the associated account
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_orgchangestatus")]
		public Microsoft.Xrm.Sdk.OptionSetValue msdyn_orgchangestatus
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("msdyn_orgchangestatus");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_orgchangestatus");
				this.SetAttributeValue("msdyn_orgchangestatus", value);
				this.OnPropertyChanged("msdyn_orgchangestatus");
			}
		}
		
		/// <summary>
		/// Indicates the date and time that the person agreed to the portal terms and conditions.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_portaltermsagreementdate")]
		public System.Nullable<System.DateTime> msdyn_portaltermsagreementdate
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("msdyn_portaltermsagreementdate");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_portaltermsagreementdate");
				this.SetAttributeValue("msdyn_portaltermsagreementdate", value);
				this.OnPropertyChanged("msdyn_portaltermsagreementdate");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyusd_currentprofile")]
		public string msdyusd_CurrentProfile
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("msdyusd_currentprofile");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyusd_CurrentProfile");
				this.SetAttributeValue("msdyusd_currentprofile", value);
				this.OnPropertyChanged("msdyusd_CurrentProfile");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyusd_facebook")]
		public string msdyusd_Facebook
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("msdyusd_facebook");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyusd_Facebook");
				this.SetAttributeValue("msdyusd_facebook", value);
				this.OnPropertyChanged("msdyusd_Facebook");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyusd_twitter")]
		public string msdyusd_Twitter
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("msdyusd_twitter");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyusd_Twitter");
				this.SetAttributeValue("msdyusd_twitter", value);
				this.OnPropertyChanged("msdyusd_Twitter");
			}
		}
	
		
		/// <summary>
		/// Type the contact's nickname.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("nickname")]
		public string NickName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("nickname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("NickName");
				this.SetAttributeValue("nickname", value);
				this.OnPropertyChanged("NickName");
			}
		}
		
		/// <summary>
		/// Type the number of children the contact has for reference in follow-up phone calls and other communications.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("numberofchildren")]
		public System.Nullable<int> NumberOfChildren
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("numberofchildren");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("NumberOfChildren");
				this.SetAttributeValue("numberofchildren", value);
				this.OnPropertyChanged("NumberOfChildren");
			}
		}
		
		/// <summary>
		/// Shows how long, in minutes, that the record was on hold.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("onholdtime")]
		public System.Nullable<int> OnHoldTime
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("onholdtime");
			}
		}
		
		/// <summary>
		/// Shows the lead that the contact was created if the contact was created by converting a lead in Microsoft Dynamics 365. This is used to relate the contact to the data on the originating lead for use in reporting and analytics.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("originatingleadid")]
		public Microsoft.Xrm.Sdk.EntityReference OriginatingLeadId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("originatingleadid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OriginatingLeadId");
				this.SetAttributeValue("originatingleadid", value);
				this.OnPropertyChanged("OriginatingLeadId");
			}
		}
		
		/// <summary>
		/// Date and time that the record was migrated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
		public System.Nullable<System.DateTime> OverriddenCreatedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OverriddenCreatedOn");
				this.SetAttributeValue("overriddencreatedon", value);
				this.OnPropertyChanged("OverriddenCreatedOn");
			}
		}
		
		/// <summary>
		/// Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
		public Microsoft.Xrm.Sdk.EntityReference OwnerId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OwnerId");
				this.SetAttributeValue("ownerid", value);
				this.OnPropertyChanged("OwnerId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the business unit that owns the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit");
			}
		}
		
		/// <summary>
		/// Unique identifier of the team who owns the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		public Microsoft.Xrm.Sdk.EntityReference OwningTeam
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who owns the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		public Microsoft.Xrm.Sdk.EntityReference OwningUser
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser");
			}
		}
		
		/// <summary>
		/// Type the pager number for the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pager")]
		public string Pager
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("pager");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Pager");
				this.SetAttributeValue("pager", value);
				this.OnPropertyChanged("Pager");
			}
		}
		
		/// <summary>
		/// Unique identifier of the parent contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentcontactid")]
		public Microsoft.Xrm.Sdk.EntityReference ParentContactId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentcontactid");
			}
		}
		
		/// <summary>
		/// Select the parent account or parent contact for the contact to provide a quick link to additional details, such as financial information, activities, and opportunities.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentcustomerid")]
		public Microsoft.Xrm.Sdk.EntityReference ParentCustomerId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentcustomerid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ParentCustomerId");
				this.SetAttributeValue("parentcustomerid", value);
				this.OnPropertyChanged("ParentCustomerId");
			}
		}
		
		/// <summary>
		/// Shows whether the contact participates in workflow rules.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("participatesinworkflow")]
		public System.Nullable<bool> ParticipatesInWorkflow
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("participatesinworkflow");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ParticipatesInWorkflow");
				this.SetAttributeValue("participatesinworkflow", value);
				this.OnPropertyChanged("ParticipatesInWorkflow");
			}
		}
		
		/// <summary>
		/// Select the payment terms to indicate when the customer needs to pay the total amount.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("paymenttermscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue PaymentTermsCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("paymenttermscode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PaymentTermsCode");
				this.SetAttributeValue("paymenttermscode", value);
				this.OnPropertyChanged("PaymentTermsCode");
			}
		}
		
		/// <summary>
		/// Select the preferred day of the week for service appointments.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredappointmentdaycode")]
		public Microsoft.Xrm.Sdk.OptionSetValue PreferredAppointmentDayCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("preferredappointmentdaycode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PreferredAppointmentDayCode");
				this.SetAttributeValue("preferredappointmentdaycode", value);
				this.OnPropertyChanged("PreferredAppointmentDayCode");
			}
		}
		
		/// <summary>
		/// Select the preferred time of day for service appointments.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredappointmenttimecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue PreferredAppointmentTimeCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("preferredappointmenttimecode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PreferredAppointmentTimeCode");
				this.SetAttributeValue("preferredappointmenttimecode", value);
				this.OnPropertyChanged("PreferredAppointmentTimeCode");
			}
		}
		
		/// <summary>
		/// Select the preferred method of contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredcontactmethodcode")]
		public Microsoft.Xrm.Sdk.OptionSetValue PreferredContactMethodCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("preferredcontactmethodcode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PreferredContactMethodCode");
				this.SetAttributeValue("preferredcontactmethodcode", value);
				this.OnPropertyChanged("PreferredContactMethodCode");
			}
		}
		
		/// <summary>
		/// Choose the contact's preferred service facility or equipment to make sure services are scheduled correctly for the customer.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredequipmentid")]
		public Microsoft.Xrm.Sdk.EntityReference PreferredEquipmentId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("preferredequipmentid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PreferredEquipmentId");
				this.SetAttributeValue("preferredequipmentid", value);
				this.OnPropertyChanged("PreferredEquipmentId");
			}
		}
		
		/// <summary>
		/// Choose the contact's preferred service to make sure services are scheduled correctly for the customer.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredserviceid")]
		public Microsoft.Xrm.Sdk.EntityReference PreferredServiceId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("preferredserviceid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PreferredServiceId");
				this.SetAttributeValue("preferredserviceid", value);
				this.OnPropertyChanged("PreferredServiceId");
			}
		}
		
		/// <summary>
		/// Choose the regular or preferred customer service representative for reference when scheduling service activities for the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredsystemuserid")]
		public Microsoft.Xrm.Sdk.EntityReference PreferredSystemUserId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("preferredsystemuserid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PreferredSystemUserId");
				this.SetAttributeValue("preferredsystemuserid", value);
				this.OnPropertyChanged("PreferredSystemUserId");
			}
		}
		
		/// <summary>
		/// Shows the ID of the process.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processid")]
		public System.Nullable<System.Guid> ProcessId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("processid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ProcessId");
				this.SetAttributeValue("processid", value);
				this.OnPropertyChanged("ProcessId");
			}
		}
		
		/// <summary>
		/// Type the salutation of the contact to make sure the contact is addressed correctly in sales calls, email messages, and marketing campaigns.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salutation")]
		public string Salutation
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("salutation");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Salutation");
				this.SetAttributeValue("salutation", value);
				this.OnPropertyChanged("Salutation");
			}
		}
		
		/// <summary>
		/// Select a shipping method for deliveries sent to this address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shippingmethodcode")]
		public Microsoft.Xrm.Sdk.OptionSetValue ShippingMethodCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("shippingmethodcode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ShippingMethodCode");
				this.SetAttributeValue("shippingmethodcode", value);
				this.OnPropertyChanged("ShippingMethodCode");
			}
		}
		
		/// <summary>
		/// Choose the service level agreement (SLA) that you want to apply to the Contact record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("slaid")]
		public Microsoft.Xrm.Sdk.EntityReference SLAId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("slaid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SLAId");
				this.SetAttributeValue("slaid", value);
				this.OnPropertyChanged("SLAId");
			}
		}
		
		/// <summary>
		/// Last SLA that was applied to this case. This field is for internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("slainvokedid")]
		public Microsoft.Xrm.Sdk.EntityReference SLAInvokedId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("slainvokedid");
			}
		}
		
		/// <summary>
		/// Type the name of the contact's spouse or partner for reference during calls, events, or other communications with the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("spousesname")]
		public string SpousesName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("spousesname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SpousesName");
				this.SetAttributeValue("spousesname", value);
				this.OnPropertyChanged("SpousesName");
			}
		}
		
		/// <summary>
		/// Shows the ID of the stage.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stageid")]
		public System.Nullable<System.Guid> StageId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("stageid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("StageId");
				this.SetAttributeValue("stageid", value);
				this.OnPropertyChanged("StageId");
			}
		}
		
		/// <summary>
		/// Shows whether the contact is active or inactive. Inactive contacts are read-only and can't be edited unless they are reactivated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<D365.BaseSolution.Base.Entities.ContactState> StateCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((D365.BaseSolution.Base.Entities.ContactState)(System.Enum.ToObject(typeof(D365.BaseSolution.Base.Entities.ContactState), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("StateCode");
				if ((value == null))
				{
					this.SetAttributeValue("statecode", null);
				}
				else
				{
					this.SetAttributeValue("statecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("StateCode");
			}
		}
		
		/// <summary>
		/// Select the contact's status.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue StatusCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("StatusCode");
				this.SetAttributeValue("statuscode", value);
				this.OnPropertyChanged("StatusCode");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("subscriptionid")]
		public System.Nullable<System.Guid> SubscriptionId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("subscriptionid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SubscriptionId");
				this.SetAttributeValue("subscriptionid", value);
				this.OnPropertyChanged("SubscriptionId");
			}
		}
		
		/// <summary>
		/// Type the suffix used in the contact's name, such as Jr. or Sr. to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("suffix")]
		public string Suffix
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("suffix");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Suffix");
				this.SetAttributeValue("suffix", value);
				this.OnPropertyChanged("Suffix");
			}
		}
		
		/// <summary>
		/// Number of users or conversations followed the record
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("teamsfollowed")]
		public System.Nullable<int> TeamsFollowed
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("teamsfollowed");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TeamsFollowed");
				this.SetAttributeValue("teamsfollowed", value);
				this.OnPropertyChanged("TeamsFollowed");
			}
		}
		
		/// <summary>
		/// Type the main phone number for this contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("telephone1")]
		public string Telephone1
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("telephone1");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Telephone1");
				this.SetAttributeValue("telephone1", value);
				this.OnPropertyChanged("Telephone1");
			}
		}
		
		/// <summary>
		/// Type a second phone number for this contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("telephone2")]
		public string Telephone2
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("telephone2");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Telephone2");
				this.SetAttributeValue("telephone2", value);
				this.OnPropertyChanged("Telephone2");
			}
		}
		
		/// <summary>
		/// Type a third phone number for this contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("telephone3")]
		public string Telephone3
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("telephone3");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Telephone3");
				this.SetAttributeValue("telephone3", value);
				this.OnPropertyChanged("Telephone3");
			}
		}
		
		/// <summary>
		/// Select a region or territory for the contact for use in segmentation and analysis.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("territorycode")]
		public Microsoft.Xrm.Sdk.OptionSetValue TerritoryCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("territorycode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TerritoryCode");
				this.SetAttributeValue("territorycode", value);
				this.OnPropertyChanged("TerritoryCode");
			}
		}
		
		/// <summary>
		/// Total time spent for emails (read and write) and meetings by me in relation to the contact record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timespentbymeonemailandmeetings")]
		public string TimeSpentByMeOnEmailAndMeetings
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("timespentbymeonemailandmeetings");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
		public System.Nullable<int> TimeZoneRuleVersionNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TimeZoneRuleVersionNumber");
				this.SetAttributeValue("timezoneruleversionnumber", value);
				this.OnPropertyChanged("TimeZoneRuleVersionNumber");
			}
		}
		
		/// <summary>
		/// Choose the local currency for the record to make sure budgets are reported in the correct currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		public Microsoft.Xrm.Sdk.EntityReference TransactionCurrencyId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("transactioncurrencyid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TransactionCurrencyId");
				this.SetAttributeValue("transactioncurrencyid", value);
				this.OnPropertyChanged("TransactionCurrencyId");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("traversedpath")]
		public string TraversedPath
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("traversedpath");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TraversedPath");
				this.SetAttributeValue("traversedpath", value);
				this.OnPropertyChanged("TraversedPath");
			}
		}
		
		/// <summary>
		/// Time zone code that was in use when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
		public System.Nullable<int> UTCConversionTimeZoneCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("UTCConversionTimeZoneCode");
				this.SetAttributeValue("utcconversiontimezonecode", value);
				this.OnPropertyChanged("UTCConversionTimeZoneCode");
			}
		}
		
		/// <summary>
		/// Version number of the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// Type the contact's professional or personal website or blog URL.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("websiteurl")]
		public string WebSiteUrl
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("websiteurl");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("WebSiteUrl");
				this.SetAttributeValue("websiteurl", value);
				this.OnPropertyChanged("WebSiteUrl");
			}
		}
		
		/// <summary>
		/// Type the phonetic spelling of the contact's first name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomifirstname")]
		public string YomiFirstName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("yomifirstname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("YomiFirstName");
				this.SetAttributeValue("yomifirstname", value);
				this.OnPropertyChanged("YomiFirstName");
			}
		}
		
		/// <summary>
		/// Shows the combined Yomi first and last names of the contact so that the full phonetic name can be displayed in views and reports.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomifullname")]
		public string YomiFullName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("yomifullname");
			}
		}
		
		/// <summary>
		/// Type the phonetic spelling of the contact's last name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomilastname")]
		public string YomiLastName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("yomilastname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("YomiLastName");
				this.SetAttributeValue("yomilastname", value);
				this.OnPropertyChanged("YomiLastName");
			}
		}
		
		/// <summary>
		/// Type the phonetic spelling of the contact's middle name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomimiddlename")]
		public string YomiMiddleName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("yomimiddlename");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("YomiMiddleName");
				this.SetAttributeValue("yomimiddlename", value);
				this.OnPropertyChanged("YomiMiddleName");
			}
		}
		
		/// <summary>
		/// 1:N account_primary_contact
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_primary_contact")]
		public System.Collections.Generic.IEnumerable<D365.BaseSolution.Base.Entities.Account> account_primary_contact
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<D365.BaseSolution.Base.Entities.Account>("account_primary_contact", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("account_primary_contact");
				this.SetRelatedEntities<D365.BaseSolution.Base.Entities.Account>("account_primary_contact", null, value);
				this.OnPropertyChanged("account_primary_contact");
			}
		}
		
		/// <summary>
		/// 1:N adx_account_created_by_portal_contact
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("adx_account_created_by_portal_contact")]
		public System.Collections.Generic.IEnumerable<D365.BaseSolution.Base.Entities.Account> adx_account_created_by_portal_contact
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<D365.BaseSolution.Base.Entities.Account>("adx_account_created_by_portal_contact", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_account_created_by_portal_contact");
				this.SetRelatedEntities<D365.BaseSolution.Base.Entities.Account>("adx_account_created_by_portal_contact", null, value);
				this.OnPropertyChanged("adx_account_created_by_portal_contact");
			}
		}
		
		/// <summary>
		/// 1:N adx_created_by_portal_contact
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("adx_created_by_portal_contact", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
		public System.Collections.Generic.IEnumerable<D365.BaseSolution.Base.Entities.Contact> Referencedadx_created_by_portal_contact
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<D365.BaseSolution.Base.Entities.Contact>("adx_created_by_portal_contact", Microsoft.Xrm.Sdk.EntityRole.Referenced);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Referencedadx_created_by_portal_contact");
				this.SetRelatedEntities<D365.BaseSolution.Base.Entities.Contact>("adx_created_by_portal_contact", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
				this.OnPropertyChanged("Referencedadx_created_by_portal_contact");
			}
		}
		
		/// <summary>
		/// 1:N contact_customer_contacts
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_customer_contacts", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
		public System.Collections.Generic.IEnumerable<D365.BaseSolution.Base.Entities.Contact> Referencedcontact_customer_contacts
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<D365.BaseSolution.Base.Entities.Contact>("contact_customer_contacts", Microsoft.Xrm.Sdk.EntityRole.Referenced);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Referencedcontact_customer_contacts");
				this.SetRelatedEntities<D365.BaseSolution.Base.Entities.Contact>("contact_customer_contacts", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
				this.OnPropertyChanged("Referencedcontact_customer_contacts");
			}
		}
		
		/// <summary>
		/// 1:N contact_master_contact
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_master_contact", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
		public System.Collections.Generic.IEnumerable<D365.BaseSolution.Base.Entities.Contact> Referencedcontact_master_contact
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<D365.BaseSolution.Base.Entities.Contact>("contact_master_contact", Microsoft.Xrm.Sdk.EntityRole.Referenced);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Referencedcontact_master_contact");
				this.SetRelatedEntities<D365.BaseSolution.Base.Entities.Contact>("contact_master_contact", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
				this.OnPropertyChanged("Referencedcontact_master_contact");
			}
		}
		
		/// <summary>
		/// N:N adx_account_contact_partnersellers
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("adx_account_contact_partnersellers")]
		public System.Collections.Generic.IEnumerable<D365.BaseSolution.Base.Entities.Account> adx_account_contact_partnersellers
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<D365.BaseSolution.Base.Entities.Account>("adx_account_contact_partnersellers", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_account_contact_partnersellers");
				this.SetRelatedEntities<D365.BaseSolution.Base.Entities.Account>("adx_account_contact_partnersellers", null, value);
				this.OnPropertyChanged("adx_account_contact_partnersellers");
			}
		}
		
		/// <summary>
		/// N:N cr4f0_Account_Contact_Contact
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("cr4f0_Account_Contact_Contact")]
		public System.Collections.Generic.IEnumerable<D365.BaseSolution.Base.Entities.Account> cr4f0_Account_Contact_Contact
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<D365.BaseSolution.Base.Entities.Account>("cr4f0_Account_Contact_Contact", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("cr4f0_Account_Contact_Contact");
				this.SetRelatedEntities<D365.BaseSolution.Base.Entities.Account>("cr4f0_Account_Contact_Contact", null, value);
				this.OnPropertyChanged("cr4f0_Account_Contact_Contact");
			}
		}
		
		/// <summary>
		/// N:1 adx_created_by_portal_contact
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_createdbyportalcontactid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("adx_created_by_portal_contact", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
		public D365.BaseSolution.Base.Entities.Contact Referencingadx_created_by_portal_contact
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<D365.BaseSolution.Base.Entities.Contact>("adx_created_by_portal_contact", Microsoft.Xrm.Sdk.EntityRole.Referencing);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Referencingadx_created_by_portal_contact");
				this.SetRelatedEntity<D365.BaseSolution.Base.Entities.Contact>("adx_created_by_portal_contact", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
				this.OnPropertyChanged("Referencingadx_created_by_portal_contact");
			}
		}
		
		/// <summary>
		/// N:1 contact_customer_accounts
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentcustomerid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_customer_accounts")]
		public D365.BaseSolution.Base.Entities.Account contact_customer_accounts
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<D365.BaseSolution.Base.Entities.Account>("contact_customer_accounts", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("contact_customer_accounts");
				this.SetRelatedEntity<D365.BaseSolution.Base.Entities.Account>("contact_customer_accounts", null, value);
				this.OnPropertyChanged("contact_customer_accounts");
			}
		}
		
		/// <summary>
		/// N:1 contact_customer_contacts
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentcustomerid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_customer_contacts", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
		public D365.BaseSolution.Base.Entities.Contact Referencingcontact_customer_contacts
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<D365.BaseSolution.Base.Entities.Contact>("contact_customer_contacts", Microsoft.Xrm.Sdk.EntityRole.Referencing);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Referencingcontact_customer_contacts");
				this.SetRelatedEntity<D365.BaseSolution.Base.Entities.Contact>("contact_customer_contacts", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
				this.OnPropertyChanged("Referencingcontact_customer_contacts");
			}
		}
		
		/// <summary>
		/// N:1 contact_master_contact
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("masterid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_master_contact", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
		public D365.BaseSolution.Base.Entities.Contact Referencingcontact_master_contact
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<D365.BaseSolution.Base.Entities.Contact>("contact_master_contact", Microsoft.Xrm.Sdk.EntityRole.Referencing);
			}
		}
		
		/// <summary>
		/// N:1 msa_contact_managingpartner
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msa_managingpartnerid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msa_contact_managingpartner")]
		public D365.BaseSolution.Base.Entities.Account msa_contact_managingpartner
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<D365.BaseSolution.Base.Entities.Account>("msa_contact_managingpartner", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msa_contact_managingpartner");
				this.SetRelatedEntity<D365.BaseSolution.Base.Entities.Account>("msa_contact_managingpartner", null, value);
				this.OnPropertyChanged("msa_contact_managingpartner");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public Contact(object anonymousType) : 
				this()
		{
            foreach (var p in anonymousType.GetType().GetProperties())
            {
                var value = p.GetValue(anonymousType, null);
                var name = p.Name.ToLower();
            
                if (name.EndsWith("enum") && value.GetType().BaseType == typeof(System.Enum))
                {
                    value = new Microsoft.Xrm.Sdk.OptionSetValue((int) value);
                    name = name.Remove(name.Length - "enum".Length);
                }
            
                switch (name)
                {
                    case "id":
                        base.Id = (System.Guid)value;
                        Attributes["contactid"] = base.Id;
                        break;
                    case "contactid":
                        var id = (System.Nullable<System.Guid>) value;
                        if(id == null){ continue; }
                        base.Id = id.Value;
                        Attributes[name] = base.Id;
                        break;
                    case "formattedvalues":
                        // Add Support for FormattedValues
                        FormattedValues.AddRange((Microsoft.Xrm.Sdk.FormattedValueCollection)value);
                        break;
                    default:
                        Attributes[name] = value;
                        break;
                }
            }
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountrolecode")]
		public virtual Contact_AccountRoleCode? AccountRoleCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((Contact_AccountRoleCode?)(EntityOptionSetEnum.GetEnum(this, "accountrolecode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				AccountRoleCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_addresstypecode")]
		public virtual Contact_Address1_AddressTypeCode? Address1_AddressTypeCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((Contact_Address1_AddressTypeCode?)(EntityOptionSetEnum.GetEnum(this, "address1_addresstypecode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				Address1_AddressTypeCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_freighttermscode")]
		public virtual Contact_Address1_FreightTermsCode? Address1_FreightTermsCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((Contact_Address1_FreightTermsCode?)(EntityOptionSetEnum.GetEnum(this, "address1_freighttermscode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				Address1_FreightTermsCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_shippingmethodcode")]
		public virtual Contact_Address1_ShippingMethodCode? Address1_ShippingMethodCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((Contact_Address1_ShippingMethodCode?)(EntityOptionSetEnum.GetEnum(this, "address1_shippingmethodcode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				Address1_ShippingMethodCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_addresstypecode")]
		public virtual Contact_Address2_AddressTypeCode? Address2_AddressTypeCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((Contact_Address2_AddressTypeCode?)(EntityOptionSetEnum.GetEnum(this, "address2_addresstypecode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				Address2_AddressTypeCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_freighttermscode")]
		public virtual Contact_Address2_FreightTermsCode? Address2_FreightTermsCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((Contact_Address2_FreightTermsCode?)(EntityOptionSetEnum.GetEnum(this, "address2_freighttermscode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				Address2_FreightTermsCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_shippingmethodcode")]
		public virtual Contact_Address2_ShippingMethodCode? Address2_ShippingMethodCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((Contact_Address2_ShippingMethodCode?)(EntityOptionSetEnum.GetEnum(this, "address2_shippingmethodcode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				Address2_ShippingMethodCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_addresstypecode")]
		public virtual Contact_Address3_AddressTypeCode? Address3_AddressTypeCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((Contact_Address3_AddressTypeCode?)(EntityOptionSetEnum.GetEnum(this, "address3_addresstypecode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				Address3_AddressTypeCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_freighttermscode")]
		public virtual Contact_Address3_FreightTermsCode? Address3_FreightTermsCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((Contact_Address3_FreightTermsCode?)(EntityOptionSetEnum.GetEnum(this, "address3_freighttermscode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				Address3_FreightTermsCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_shippingmethodcode")]
		public virtual Contact_Address3_ShippingMethodCode? Address3_ShippingMethodCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((Contact_Address3_ShippingMethodCode?)(EntityOptionSetEnum.GetEnum(this, "address3_shippingmethodcode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				Address3_ShippingMethodCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_partner_applicationstatus")]
		public virtual Contact_adx_partner_applicationstatus? adx_partner_applicationstatusEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((Contact_adx_partner_applicationstatus?)(EntityOptionSetEnum.GetEnum(this, "adx_partner_applicationstatus")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				adx_partner_applicationstatus = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_partnercontactrole")]
		public virtual adx_PartnerContactRoles? adx_PartnerContactRoleEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((adx_PartnerContactRoles?)(EntityOptionSetEnum.GetEnum(this, "adx_partnercontactrole")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				adx_PartnerContactRole = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customersizecode")]
		public virtual Contact_CustomerSizeCode? CustomerSizeCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((Contact_CustomerSizeCode?)(EntityOptionSetEnum.GetEnum(this, "customersizecode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				CustomerSizeCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customertypecode")]
		public virtual Contact_CustomerTypeCode? CustomerTypeCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((Contact_CustomerTypeCode?)(EntityOptionSetEnum.GetEnum(this, "customertypecode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				CustomerTypeCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("educationcode")]
		public virtual Contact_EducationCode? EducationCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((Contact_EducationCode?)(EntityOptionSetEnum.GetEnum(this, "educationcode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				EducationCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("familystatuscode")]
		public virtual Contact_FamilyStatusCode? FamilyStatusCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((Contact_FamilyStatusCode?)(EntityOptionSetEnum.GetEnum(this, "familystatuscode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				FamilyStatusCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("gendercode")]
		public virtual Contact_GenderCode? GenderCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((Contact_GenderCode?)(EntityOptionSetEnum.GetEnum(this, "gendercode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				GenderCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("haschildrencode")]
		public virtual Contact_HasChildrenCode? HasChildrenCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((Contact_HasChildrenCode?)(EntityOptionSetEnum.GetEnum(this, "haschildrencode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				HasChildrenCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("leadsourcecode")]
		public virtual Contact_LeadSourceCode? LeadSourceCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((Contact_LeadSourceCode?)(EntityOptionSetEnum.GetEnum(this, "leadsourcecode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				LeadSourceCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_orgchangestatus")]
		public virtual Contact_msdyn_orgchangestatus? msdyn_orgchangestatusEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((Contact_msdyn_orgchangestatus?)(EntityOptionSetEnum.GetEnum(this, "msdyn_orgchangestatus")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				msdyn_orgchangestatus = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("paymenttermscode")]
		public virtual Contact_PaymentTermsCode? PaymentTermsCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((Contact_PaymentTermsCode?)(EntityOptionSetEnum.GetEnum(this, "paymenttermscode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				PaymentTermsCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredappointmentdaycode")]
		public virtual Contact_PreferredAppointmentDayCode? PreferredAppointmentDayCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((Contact_PreferredAppointmentDayCode?)(EntityOptionSetEnum.GetEnum(this, "preferredappointmentdaycode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				PreferredAppointmentDayCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredappointmenttimecode")]
		public virtual Contact_PreferredAppointmentTimeCode? PreferredAppointmentTimeCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((Contact_PreferredAppointmentTimeCode?)(EntityOptionSetEnum.GetEnum(this, "preferredappointmenttimecode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				PreferredAppointmentTimeCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredcontactmethodcode")]
		public virtual Contact_PreferredContactMethodCode? PreferredContactMethodCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((Contact_PreferredContactMethodCode?)(EntityOptionSetEnum.GetEnum(this, "preferredcontactmethodcode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				PreferredContactMethodCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shippingmethodcode")]
		public virtual Contact_ShippingMethodCode? ShippingMethodCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((Contact_ShippingMethodCode?)(EntityOptionSetEnum.GetEnum(this, "shippingmethodcode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				ShippingMethodCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public virtual Contact_StatusCode? StatusCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((Contact_StatusCode?)(EntityOptionSetEnum.GetEnum(this, "statuscode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				StatusCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("territorycode")]
		public virtual Contact_TerritoryCode? TerritoryCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((Contact_TerritoryCode?)(EntityOptionSetEnum.GetEnum(this, "territorycode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				TerritoryCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
	}
	
	/// <summary>
	/// Represents a source of entities bound to a CRM service. It tracks and manages changes made to the retrieved entities.
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9479")]
	public partial class CrmServiceContext : Microsoft.Xrm.Sdk.Client.OrganizationServiceContext
	{
		
		/// <summary>
		/// Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public CrmServiceContext(Microsoft.Xrm.Sdk.IOrganizationService service) : 
				base(service)
		{
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="D365.BaseSolution.Base.Entities.Account"/> entities.
		/// </summary>
		public System.Linq.IQueryable<D365.BaseSolution.Base.Entities.Account> AccountSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<D365.BaseSolution.Base.Entities.Account>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="D365.BaseSolution.Base.Entities.Contact"/> entities.
		/// </summary>
		public System.Linq.IQueryable<D365.BaseSolution.Base.Entities.Contact> ContactSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<D365.BaseSolution.Base.Entities.Contact>();
			}
		}
	}
	
	internal sealed class EntityOptionSetEnum
	{
		
		[System.Diagnostics.DebuggerNonUserCode()]
		public static System.Nullable<int> GetEnum(Microsoft.Xrm.Sdk.Entity entity, string attributeLogicalName)
		{
			if (entity.Attributes.ContainsKey(attributeLogicalName))
			{
				Microsoft.Xrm.Sdk.OptionSetValue value = entity.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>(attributeLogicalName);
				if (value != null)
				{
					return value.Value;
				}
			}
			return null;
		}
	}
}
