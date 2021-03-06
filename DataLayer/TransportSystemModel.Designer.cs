﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("TransportSystemModel", "FK_COMPANIES", "Companies", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(DataLayer.Company), "Travels", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(DataLayer.Travel), true)]
[assembly: EdmRelationshipAttribute("TransportSystemModel", "FK_TRAVELS", "Travels", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(DataLayer.Travel), "Stops", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(DataLayer.Stop), true)]

#endregion

namespace DataLayer
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class TransportSystemDB : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new TransportSystemDB object using the connection string found in the 'TransportSystemDB' section of the application configuration file.
        /// </summary>
        public TransportSystemDB() : base("name=TransportSystemDB", "TransportSystemDB")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new TransportSystemDB object.
        /// </summary>
        public TransportSystemDB(string connectionString) : base(connectionString, "TransportSystemDB")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new TransportSystemDB object.
        /// </summary>
        public TransportSystemDB(EntityConnection connection) : base(connection, "TransportSystemDB")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Company> Companies
        {
            get
            {
                if ((_Companies == null))
                {
                    _Companies = base.CreateObjectSet<Company>("Companies");
                }
                return _Companies;
            }
        }
        private ObjectSet<Company> _Companies;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Stop> Stops
        {
            get
            {
                if ((_Stops == null))
                {
                    _Stops = base.CreateObjectSet<Stop>("Stops");
                }
                return _Stops;
            }
        }
        private ObjectSet<Stop> _Stops;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Travel> Travels
        {
            get
            {
                if ((_Travels == null))
                {
                    _Travels = base.CreateObjectSet<Travel>("Travels");
                }
                return _Travels;
            }
        }
        private ObjectSet<Travel> _Travels;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Companies EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToCompanies(Company company)
        {
            base.AddObject("Companies", company);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Stops EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToStops(Stop stop)
        {
            base.AddObject("Stops", stop);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Travels EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToTravels(Travel travel)
        {
            base.AddObject("Travels", travel);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="TransportSystemModel", Name="Company")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Company : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Company object.
        /// </summary>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="city">Initial value of the City property.</param>
        /// <param name="address">Initial value of the Address property.</param>
        /// <param name="phoneNumber">Initial value of the PhoneNumber property.</param>
        /// <param name="email">Initial value of the Email property.</param>
        public static Company CreateCompany(global::System.String name, global::System.String city, global::System.String address, global::System.String phoneNumber, global::System.String email)
        {
            Company company = new Company();
            company.Name = name;
            company.City = city;
            company.Address = address;
            company.PhoneNumber = phoneNumber;
            company.Email = email;
            return company;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                if (_Name != value)
                {
                    OnNameChanging(value);
                    ReportPropertyChanging("Name");
                    _Name = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("Name");
                    OnNameChanged();
                }
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String City
        {
            get
            {
                return _City;
            }
            set
            {
                OnCityChanging(value);
                ReportPropertyChanging("City");
                _City = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("City");
                OnCityChanged();
            }
        }
        private global::System.String _City;
        partial void OnCityChanging(global::System.String value);
        partial void OnCityChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Address
        {
            get
            {
                return _Address;
            }
            set
            {
                OnAddressChanging(value);
                ReportPropertyChanging("Address");
                _Address = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Address");
                OnAddressChanged();
            }
        }
        private global::System.String _Address;
        partial void OnAddressChanging(global::System.String value);
        partial void OnAddressChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String PhoneNumber
        {
            get
            {
                return _PhoneNumber;
            }
            set
            {
                OnPhoneNumberChanging(value);
                ReportPropertyChanging("PhoneNumber");
                _PhoneNumber = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("PhoneNumber");
                OnPhoneNumberChanged();
            }
        }
        private global::System.String _PhoneNumber;
        partial void OnPhoneNumberChanging(global::System.String value);
        partial void OnPhoneNumberChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Email
        {
            get
            {
                return _Email;
            }
            set
            {
                OnEmailChanging(value);
                ReportPropertyChanging("Email");
                _Email = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Email");
                OnEmailChanged();
            }
        }
        private global::System.String _Email;
        partial void OnEmailChanging(global::System.String value);
        partial void OnEmailChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("TransportSystemModel", "FK_COMPANIES", "Travels")]
        public EntityCollection<Travel> Travels
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Travel>("TransportSystemModel.FK_COMPANIES", "Travels");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Travel>("TransportSystemModel.FK_COMPANIES", "Travels", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="TransportSystemModel", Name="Stop")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Stop : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Stop object.
        /// </summary>
        /// <param name="id">Initial value of the id property.</param>
        /// <param name="stop1">Initial value of the stop1 property.</param>
        public static Stop CreateStop(global::System.Int32 id, global::System.String stop1)
        {
            Stop stop = new Stop();
            stop.id = id;
            stop.stop1 = stop1;
            return stop;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    OnidChanging(value);
                    ReportPropertyChanging("id");
                    _id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id");
                    OnidChanged();
                }
            }
        }
        private global::System.Int32 _id;
        partial void OnidChanging(global::System.Int32 value);
        partial void OnidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String stop1
        {
            get
            {
                return _stop1;
            }
            set
            {
                if (_stop1 != value)
                {
                    Onstop1Changing(value);
                    ReportPropertyChanging("stop1");
                    _stop1 = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("stop1");
                    Onstop1Changed();
                }
            }
        }
        private global::System.String _stop1;
        partial void Onstop1Changing(global::System.String value);
        partial void Onstop1Changed();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("TransportSystemModel", "FK_TRAVELS", "Travels")]
        public Travel Travel
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Travel>("TransportSystemModel.FK_TRAVELS", "Travels").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Travel>("TransportSystemModel.FK_TRAVELS", "Travels").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Travel> TravelReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Travel>("TransportSystemModel.FK_TRAVELS", "Travels");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Travel>("TransportSystemModel.FK_TRAVELS", "Travels", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="TransportSystemModel", Name="Travel")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Travel : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Travel object.
        /// </summary>
        /// <param name="company">Initial value of the Company property.</param>
        /// <param name="startCity">Initial value of the StartCity property.</param>
        /// <param name="startTime">Initial value of the StartTime property.</param>
        /// <param name="endCity">Initial value of the EndCity property.</param>
        /// <param name="endTime">Initial value of the EndTime property.</param>
        /// <param name="ticketPrice">Initial value of the TicketPrice property.</param>
        /// <param name="id">Initial value of the id property.</param>
        public static Travel CreateTravel(global::System.String company, global::System.String startCity, global::System.DateTime startTime, global::System.String endCity, global::System.DateTime endTime, global::System.Int32 ticketPrice, global::System.Int32 id)
        {
            Travel travel = new Travel();
            travel.Company = company;
            travel.StartCity = startCity;
            travel.StartTime = startTime;
            travel.EndCity = endCity;
            travel.EndTime = endTime;
            travel.TicketPrice = ticketPrice;
            travel.id = id;
            return travel;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Company
        {
            get
            {
                return _Company;
            }
            set
            {
                OnCompanyChanging(value);
                ReportPropertyChanging("Company");
                _Company = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Company");
                OnCompanyChanged();
            }
        }
        private global::System.String _Company;
        partial void OnCompanyChanging(global::System.String value);
        partial void OnCompanyChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String StartCity
        {
            get
            {
                return _StartCity;
            }
            set
            {
                OnStartCityChanging(value);
                ReportPropertyChanging("StartCity");
                _StartCity = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("StartCity");
                OnStartCityChanged();
            }
        }
        private global::System.String _StartCity;
        partial void OnStartCityChanging(global::System.String value);
        partial void OnStartCityChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime StartTime
        {
            get
            {
                return _StartTime;
            }
            set
            {
                OnStartTimeChanging(value);
                ReportPropertyChanging("StartTime");
                _StartTime = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("StartTime");
                OnStartTimeChanged();
            }
        }
        private global::System.DateTime _StartTime;
        partial void OnStartTimeChanging(global::System.DateTime value);
        partial void OnStartTimeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String EndCity
        {
            get
            {
                return _EndCity;
            }
            set
            {
                OnEndCityChanging(value);
                ReportPropertyChanging("EndCity");
                _EndCity = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("EndCity");
                OnEndCityChanged();
            }
        }
        private global::System.String _EndCity;
        partial void OnEndCityChanging(global::System.String value);
        partial void OnEndCityChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime EndTime
        {
            get
            {
                return _EndTime;
            }
            set
            {
                OnEndTimeChanging(value);
                ReportPropertyChanging("EndTime");
                _EndTime = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("EndTime");
                OnEndTimeChanged();
            }
        }
        private global::System.DateTime _EndTime;
        partial void OnEndTimeChanging(global::System.DateTime value);
        partial void OnEndTimeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 TicketPrice
        {
            get
            {
                return _TicketPrice;
            }
            set
            {
                OnTicketPriceChanging(value);
                ReportPropertyChanging("TicketPrice");
                _TicketPrice = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("TicketPrice");
                OnTicketPriceChanged();
            }
        }
        private global::System.Int32 _TicketPrice;
        partial void OnTicketPriceChanging(global::System.Int32 value);
        partial void OnTicketPriceChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    OnidChanging(value);
                    ReportPropertyChanging("id");
                    _id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id");
                    OnidChanged();
                }
            }
        }
        private global::System.Int32 _id;
        partial void OnidChanging(global::System.Int32 value);
        partial void OnidChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("TransportSystemModel", "FK_COMPANIES", "Companies")]
        public Company Company1
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Company>("TransportSystemModel.FK_COMPANIES", "Companies").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Company>("TransportSystemModel.FK_COMPANIES", "Companies").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Company> Company1Reference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Company>("TransportSystemModel.FK_COMPANIES", "Companies");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Company>("TransportSystemModel.FK_COMPANIES", "Companies", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("TransportSystemModel", "FK_TRAVELS", "Stops")]
        public EntityCollection<Stop> Stops
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Stop>("TransportSystemModel.FK_TRAVELS", "Stops");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Stop>("TransportSystemModel.FK_TRAVELS", "Stops", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}
