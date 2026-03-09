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
/// Set of elements used to provide information on the settlement of the instruction.
/// </summary>
[IsoId("_QJIE0Np-Ed-ak6NoX_4Aeg_-1401894087")]
[DisplayName("Settlement Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementInformation14
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SettlementInformation14 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SettlementInformation14( SettlementMethod2Code reqSettlementMethod )
    {
        SettlementMethod = reqSettlementMethod;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Method used to settle the (batch of) payment instructions.
    /// </summary>
    [IsoId("_QJIE0dp-Ed-ak6NoX_4Aeg_-1401894056")]
    [DisplayName("Settlement Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmMtd")]
    #endif
    [IsoXmlTag("SttlmMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementMethod2Code SettlementMethod { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementMethod2Code SettlementMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementMethod2Code SettlementMethod { get; init; } 
    #else
    public SettlementMethod2Code SettlementMethod { get; set; } 
    #endif
    
    /// <summary>
    /// A specific purpose account used to post debit and credit entries as a result of the transaction.
    /// </summary>
    [IsoId("_QJIE0tp-Ed-ak6NoX_4Aeg_-1401893993")]
    [DisplayName("Settlement Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmAcct")]
    #endif
    [IsoXmlTag("SttlmAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount16? SettlementAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount16? SettlementAccount { get; init; } 
    #else
    public CashAccount16? SettlementAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Specification of a pre-agreed offering between clearing agents or the channel through which the payment instruction is processed.
    /// </summary>
    [IsoId("_QJIE09p-Ed-ak6NoX_4Aeg_-1401893685")]
    [DisplayName("Clearing System")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrSys")]
    #endif
    [IsoXmlTag("ClrSys")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ClearingSystemIdentification3Choice_? ClearingSystem { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ClearingSystemIdentification3Choice_? ClearingSystem { get; init; } 
    #else
    public ClearingSystemIdentification3Choice_? ClearingSystem { get; set; } 
    #endif
    
    
    #nullable disable
    
}
