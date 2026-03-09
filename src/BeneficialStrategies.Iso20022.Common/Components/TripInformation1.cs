// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains the details related to an individual trip. 
/// </summary>
[IsoId("_X6Xf1_i3EeiJaN6-Lf-c_w")]
[DisplayName("Trip Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TripInformation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification number of the trip.
    /// </summary>
    [IsoId("_X6YG4vi3EeiJaN6-Lf-c_w")]
    [DisplayName("Trip Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TripNb")]
    #endif
    [IsoXmlTag("TripNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TripNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TripNumber { get; init; } 
    #else
    public System.String? TripNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Contains an indicator identifying the job or task identifier of the individual. 
    /// </summary>
    [IsoId("_X6YG5Pi3EeiJaN6-Lf-c_w")]
    [DisplayName("Job Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="JobNb")]
    #endif
    [IsoXmlTag("JobNb")]
    [IsoSimpleType(IsoSimpleType.Max10Text)]
    [StringLength(maximumLength: 10 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax10Text? JobNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? JobNumber { get; init; } 
    #else
    public System.String? JobNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the work order or purchase order number. 
    /// </summary>
    [IsoId("_X6YG5fi3EeiJaN6-Lf-c_w")]
    [DisplayName("Work Order")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WorkOrdr")]
    #endif
    [IsoXmlTag("WorkOrdr")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? WorkOrder { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? WorkOrder { get; init; } 
    #else
    public System.String? WorkOrder { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the invoice number. 
    /// </summary>
    [IsoId("_X6YG4fi3EeiJaN6-Lf-c_w")]
    [DisplayName("Invoice Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvcNb")]
    #endif
    [IsoXmlTag("InvcNb")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? InvoiceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InvoiceNumber { get; init; } 
    #else
    public System.String? InvoiceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the billing identification number. 
    /// </summary>
    [IsoId("_X6YG4Pi3EeiJaN6-Lf-c_w")]
    [DisplayName("Billing Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BllgId")]
    #endif
    [IsoXmlTag("BllgId")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? BillingIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BillingIdentification { get; init; } 
    #else
    public System.String? BillingIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification number assigned by an agent. 
    /// </summary>
    [IsoId("_X6YG4_i3EeiJaN6-Lf-c_w")]
    [DisplayName("Control Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrlNb")]
    #endif
    [IsoXmlTag("CtrlNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ControlNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ControlNumber { get; init; } 
    #else
    public System.String? ControlNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Delivery Ticket Number for the trip information.
    /// </summary>
    [IsoId("_kjUdAPi6EeiJaN6-Lf-c_w")]
    [DisplayName("Delivery Ticket Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvryTcktNb")]
    #endif
    [IsoXmlTag("DlvryTcktNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? DeliveryTicketNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DeliveryTicketNumber { get; init; } 
    #else
    public System.String? DeliveryTicketNumber { get; set; } 
    #endif
    
    
    #nullable disable
    
}
