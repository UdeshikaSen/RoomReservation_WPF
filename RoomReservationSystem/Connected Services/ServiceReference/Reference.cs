﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RoomReservationSystem.ServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/RoomReservationService")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneField, value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((object.ReferenceEquals(this.UserIdField, value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Room", Namespace="http://schemas.datacontract.org/2004/07/RoomReservationService")]
    [System.SerializableAttribute()]
    public partial class Room : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MaxNoOfPeopleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NoOfBedsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RoomNoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RoomStateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RoomTypeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MaxNoOfPeople {
            get {
                return this.MaxNoOfPeopleField;
            }
            set {
                if ((object.ReferenceEquals(this.MaxNoOfPeopleField, value) != true)) {
                    this.MaxNoOfPeopleField = value;
                    this.RaisePropertyChanged("MaxNoOfPeople");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NoOfBeds {
            get {
                return this.NoOfBedsField;
            }
            set {
                if ((object.ReferenceEquals(this.NoOfBedsField, value) != true)) {
                    this.NoOfBedsField = value;
                    this.RaisePropertyChanged("NoOfBeds");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Price {
            get {
                return this.PriceField;
            }
            set {
                if ((object.ReferenceEquals(this.PriceField, value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RoomNo {
            get {
                return this.RoomNoField;
            }
            set {
                if ((object.ReferenceEquals(this.RoomNoField, value) != true)) {
                    this.RoomNoField = value;
                    this.RaisePropertyChanged("RoomNo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RoomState {
            get {
                return this.RoomStateField;
            }
            set {
                if ((object.ReferenceEquals(this.RoomStateField, value) != true)) {
                    this.RoomStateField = value;
                    this.RaisePropertyChanged("RoomState");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RoomType {
            get {
                return this.RoomTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.RoomTypeField, value) != true)) {
                    this.RoomTypeField = value;
                    this.RaisePropertyChanged("RoomType");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IRoomReservationService")]
    public interface IRoomReservationService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRoomReservationService/GetUser", ReplyAction="http://tempuri.org/IRoomReservationService/GetUserResponse")]
        RoomReservationSystem.ServiceReference.User GetUser(string userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRoomReservationService/GetUser", ReplyAction="http://tempuri.org/IRoomReservationService/GetUserResponse")]
        System.Threading.Tasks.Task<RoomReservationSystem.ServiceReference.User> GetUserAsync(string userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRoomReservationService/GetUsers", ReplyAction="http://tempuri.org/IRoomReservationService/GetUsersResponse")]
        RoomReservationSystem.ServiceReference.User[] GetUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRoomReservationService/GetUsers", ReplyAction="http://tempuri.org/IRoomReservationService/GetUsersResponse")]
        System.Threading.Tasks.Task<RoomReservationSystem.ServiceReference.User[]> GetUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRoomReservationService/RegisterUser", ReplyAction="http://tempuri.org/IRoomReservationService/RegisterUserResponse")]
        string RegisterUser(string userEmail, string userName, string userPhone, string userAddress);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRoomReservationService/RegisterUser", ReplyAction="http://tempuri.org/IRoomReservationService/RegisterUserResponse")]
        System.Threading.Tasks.Task<string> RegisterUserAsync(string userEmail, string userName, string userPhone, string userAddress);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRoomReservationService/GetRooms", ReplyAction="http://tempuri.org/IRoomReservationService/GetRoomsResponse")]
        RoomReservationSystem.ServiceReference.Room[] GetRooms();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRoomReservationService/GetRooms", ReplyAction="http://tempuri.org/IRoomReservationService/GetRoomsResponse")]
        System.Threading.Tasks.Task<RoomReservationSystem.ServiceReference.Room[]> GetRoomsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRoomReservationService/GetRoomTypes", ReplyAction="http://tempuri.org/IRoomReservationService/GetRoomTypesResponse")]
        string[] GetRoomTypes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRoomReservationService/GetRoomTypes", ReplyAction="http://tempuri.org/IRoomReservationService/GetRoomTypesResponse")]
        System.Threading.Tasks.Task<string[]> GetRoomTypesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRoomReservationService/GetAvailableRooms", ReplyAction="http://tempuri.org/IRoomReservationService/GetAvailableRoomsResponse")]
        RoomReservationSystem.ServiceReference.Room[] GetAvailableRooms(string roomType, System.DateTime checkIn, System.DateTime checkOut);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRoomReservationService/GetAvailableRooms", ReplyAction="http://tempuri.org/IRoomReservationService/GetAvailableRoomsResponse")]
        System.Threading.Tasks.Task<RoomReservationSystem.ServiceReference.Room[]> GetAvailableRoomsAsync(string roomType, System.DateTime checkIn, System.DateTime checkOut);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRoomReservationService/ReserveRoom", ReplyAction="http://tempuri.org/IRoomReservationService/ReserveRoomResponse")]
        string ReserveRoom(string roomNo, int adults, int children, double reservationCost, string userEmail, System.DateTime inDateTime, System.DateTime outDateTime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRoomReservationService/ReserveRoom", ReplyAction="http://tempuri.org/IRoomReservationService/ReserveRoomResponse")]
        System.Threading.Tasks.Task<string> ReserveRoomAsync(string roomNo, int adults, int children, double reservationCost, string userEmail, System.DateTime inDateTime, System.DateTime outDateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRoomReservationServiceChannel : RoomReservationSystem.ServiceReference.IRoomReservationService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RoomReservationServiceClient : System.ServiceModel.ClientBase<RoomReservationSystem.ServiceReference.IRoomReservationService>, RoomReservationSystem.ServiceReference.IRoomReservationService {
        
        public RoomReservationServiceClient() {
        }
        
        public RoomReservationServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RoomReservationServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RoomReservationServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RoomReservationServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public RoomReservationSystem.ServiceReference.User GetUser(string userId) {
            return base.Channel.GetUser(userId);
        }
        
        public System.Threading.Tasks.Task<RoomReservationSystem.ServiceReference.User> GetUserAsync(string userId) {
            return base.Channel.GetUserAsync(userId);
        }
        
        public RoomReservationSystem.ServiceReference.User[] GetUsers() {
            return base.Channel.GetUsers();
        }
        
        public System.Threading.Tasks.Task<RoomReservationSystem.ServiceReference.User[]> GetUsersAsync() {
            return base.Channel.GetUsersAsync();
        }
        
        public string RegisterUser(string userEmail, string userName, string userPhone, string userAddress) {
            return base.Channel.RegisterUser(userEmail, userName, userPhone, userAddress);
        }
        
        public System.Threading.Tasks.Task<string> RegisterUserAsync(string userEmail, string userName, string userPhone, string userAddress) {
            return base.Channel.RegisterUserAsync(userEmail, userName, userPhone, userAddress);
        }
        
        public RoomReservationSystem.ServiceReference.Room[] GetRooms() {
            return base.Channel.GetRooms();
        }
        
        public System.Threading.Tasks.Task<RoomReservationSystem.ServiceReference.Room[]> GetRoomsAsync() {
            return base.Channel.GetRoomsAsync();
        }
        
        public string[] GetRoomTypes() {
            return base.Channel.GetRoomTypes();
        }
        
        public System.Threading.Tasks.Task<string[]> GetRoomTypesAsync() {
            return base.Channel.GetRoomTypesAsync();
        }
        
        public RoomReservationSystem.ServiceReference.Room[] GetAvailableRooms(string roomType, System.DateTime checkIn, System.DateTime checkOut) {
            return base.Channel.GetAvailableRooms(roomType, checkIn, checkOut);
        }
        
        public System.Threading.Tasks.Task<RoomReservationSystem.ServiceReference.Room[]> GetAvailableRoomsAsync(string roomType, System.DateTime checkIn, System.DateTime checkOut) {
            return base.Channel.GetAvailableRoomsAsync(roomType, checkIn, checkOut);
        }
        
        public string ReserveRoom(string roomNo, int adults, int children, double reservationCost, string userEmail, System.DateTime inDateTime, System.DateTime outDateTime) {
            return base.Channel.ReserveRoom(roomNo, adults, children, reservationCost, userEmail, inDateTime, outDateTime);
        }
        
        public System.Threading.Tasks.Task<string> ReserveRoomAsync(string roomNo, int adults, int children, double reservationCost, string userEmail, System.DateTime inDateTime, System.DateTime outDateTime) {
            return base.Channel.ReserveRoomAsync(roomNo, adults, children, reservationCost, userEmail, inDateTime, outDateTime);
        }
    }
}
