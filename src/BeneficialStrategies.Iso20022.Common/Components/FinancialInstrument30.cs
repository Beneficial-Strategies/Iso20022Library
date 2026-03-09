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
/// Security that is a sub-set of an investment fund, and is governed by the same investment fund policy, eg, dividend option or valuation currency.
/// </summary>
[IsoId("_RI9ZsRgDEeKqWJINzXcn5g")]
[DisplayName("Financial Instrument")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstrument30
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FinancialInstrument30 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FinancialInstrument30( SecurityIdentification3Choice_ reqIdentification )
    {
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier of a security, assigned under a formal or proprietary identification scheme.
    /// </summary>
    [IsoId("_RfBJSRgDEeKqWJINzXcn5g")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification3Choice_ Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecurityIdentification3Choice_ Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification3Choice_ Identification { get; init; } 
    #else
    public SecurityIdentification3Choice_ Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the financial instrument in free format text.
    /// </summary>
    [IsoId("_RfBJTRgDEeKqWJINzXcn5g")]
    [DisplayName("Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nm")]
    #endif
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Name { get; init; } 
    #else
    public System.String? Name { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the quantity of assets to be transferred in units or in a percentage rate.
    /// </summary>
    [IsoId("_RfBJURgDEeKqWJINzXcn5g")]
    [DisplayName("Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Qty")]
    #endif
    [IsoXmlTag("Qty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Quantity12Choice_? Quantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity12Choice_? Quantity { get; init; } 
    #else
    public Quantity12Choice_? Quantity { get; set; } 
    #endif
    
    /// <summary>
    /// Average cost per share of a security, including all charges and commissions.
    /// </summary>
    [IsoId("_RfBJVRgDEeKqWJINzXcn5g")]
    [DisplayName("Average Acquisition Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AvrgAcqstnPric")]
    #endif
    [IsoXmlTag("AvrgAcqstnPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? AverageAcquisitionPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? AverageAcquisitionPrice { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? AverageAcquisitionPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Net asset on balance sheet - total portfolio value minus or plus the unrealised gain or loss.
    /// </summary>
    [IsoId("_RfBJWRgDEeKqWJINzXcn5g")]
    [DisplayName("Total Book Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlBookVal")]
    #endif
    [IsoXmlTag("TtlBookVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? TotalBookValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? TotalBookValue { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? TotalBookValue { get; set; } 
    #endif
    
    /// <summary>
    /// Account held in the name of a party that is not the name of the beneficial owner of the shares.
    /// </summary>
    [IsoId("_RfBJXRgDEeKqWJINzXcn5g")]
    [DisplayName("Transferee Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfeeAcct")]
    #endif
    [IsoXmlTag("TrfeeAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Account6? TransfereeAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Account6? TransfereeAccount { get; init; } 
    #else
    public Account6? TransfereeAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Party that delivers securities to the receiving agent at the place of settlement, for example, a central securities depository.
    /// </summary>
    [IsoId("_dFutsBgDEeKqWJINzXcn5g")]
    [DisplayName("Delivering Agent Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvrgAgtDtls")]
    #endif
    [IsoXmlTag("DlvrgAgtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount93? DeliveringAgentDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount93? DeliveringAgentDetails { get; init; } 
    #else
    public PartyIdentificationAndAccount93? DeliveringAgentDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
