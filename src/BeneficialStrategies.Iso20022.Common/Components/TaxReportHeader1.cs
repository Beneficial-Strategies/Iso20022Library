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
/// Defines message level identification, number of individual tax reports and tax authority.
/// </summary>
[IsoId("_xtcK0WnzEea5EcY2TpG1mw")]
[DisplayName("Tax Report Header")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TaxReportHeader1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TaxReportHeader1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TaxReportHeader1( MessageIdentification1 reqMessageIdentification )
    {
        MessageIdentification = reqMessageIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique message identification.
    /// </summary>
    [IsoId("_FdwToGn0Eea5EcY2TpG1mw")]
    [DisplayName("Message Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgId")]
    #endif
    [IsoXmlTag("MsgId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 MessageIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageIdentification1 MessageIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 MessageIdentification { get; init; } 
    #else
    public MessageIdentification1 MessageIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Number of TaxReports in this message. Seller can send all TaxReports in the same file.
    /// </summary>
    [IsoId("_L3NwEGn0Eea5EcY2TpG1mw")]
    [DisplayName("Number Of Tax Reports")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfTaxRpts")]
    #endif
    [IsoXmlTag("NbOfTaxRpts")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? NumberOfTaxReports { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? NumberOfTaxReports { get; init; } 
    #else
    public System.UInt64? NumberOfTaxReports { get; set; } 
    #endif
    
    /// <summary>
    /// Party to which the TaxReport is delivered. This message block contains party details for a specific tax authority.
    /// </summary>
    [IsoId("_VbSuYGn0Eea5EcY2TpG1mw")]
    [DisplayName("Tax Authority")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxAuthrty")]
    #endif
    [IsoXmlTag("TaxAuthrty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxOrganisationIdentification1? TaxAuthority { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxOrganisationIdentification1? TaxAuthority { get; init; } 
    #else
    public TaxOrganisationIdentification1? TaxAuthority { get; set; } 
    #endif
    
    
    #nullable disable
    
}
