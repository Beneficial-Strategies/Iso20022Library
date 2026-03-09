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
/// Describes a transaction and its status.
/// </summary>
[IsoId("_Ra7q9tp-Ed-ak6NoX_4Aeg_-898612372")]
[DisplayName("Status Report Items")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record StatusReportItems2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a StatusReportItems2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public StatusReportItems2( System.String reqTransactionIdentification,BaselineStatus3Code reqStatus )
    {
        TransactionIdentification = reqTransactionIdentification;
        Status = reqStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.
    /// </summary>
    [IsoId("_Ra7q99p-Ed-ak6NoX_4Aeg_-898612370")]
    [DisplayName("Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxId")]
    #endif
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text TransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TransactionIdentification { get; init; } 
    #else
    public System.String TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Entity for which the matching application has generated a report.
    /// </summary>
    [IsoId("_Ra7q-Np-Ed-ak6NoX_4Aeg_-898611970")]
    [DisplayName("Reported Entity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptdNtty")]
    #endif
    [IsoXmlTag("RptdNtty")]
    [MinLength(1)]
    [MaxLength(2)]
    public ValueList<BICIdentification1> ReportedEntity { get; init; } = new ValueList<BICIdentification1>(){};
    
    /// <summary>
    /// Identifies the status of the transaction by means of a code.
    /// </summary>
    [IsoId("_RbFb8Np-Ed-ak6NoX_4Aeg_-898612311")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BaselineStatus3Code Status { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BaselineStatus3Code Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BaselineStatus3Code Status { get; init; } 
    #else
    public BaselineStatus3Code Status { get; set; } 
    #endif
    
    /// <summary>
    /// Further description of the transaction status.
    /// </summary>
    [IsoId("_RbFb8dp-Ed-ak6NoX_4Aeg_-898612280")]
    [DisplayName("Sub Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubSts")]
    #endif
    [IsoXmlTag("SubSts")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? SubStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SubStatus { get; init; } 
    #else
    public System.String? SubStatus { get; set; } 
    #endif
    
    
    #nullable disable
    
}
