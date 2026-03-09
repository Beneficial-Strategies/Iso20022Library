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
/// Specifies the obligations of one of the participants to a derivative contract. The obligations may be conceptual or operational only, with settlement of any obligations arising from the derivative contract taking place on a net basis, after the netting of the obligations arising from each leg of the contract.
/// </summary>
[IsoId("_zoVNcMhqEeadgvwNGwK05w")]
[DisplayName("Derivative Underlying Leg")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DerivativeUnderlyingLeg1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DerivativeUnderlyingLeg1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DerivativeUnderlyingLeg1( FinancialInstrumentAttributes88 reqContractAttributes )
    {
        ContractAttributes = reqContractAttributes;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Attributes that relate to the financial instrument (contract) being traded that are common across derivatives.
    /// </summary>
    [IsoId("_-u88kMhqEeadgvwNGwK05w")]
    [DisplayName("Contract Attributes")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrctAttrbts")]
    #endif
    [IsoXmlTag("CtrctAttrbts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrumentAttributes88 ContractAttributes { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrumentAttributes88 ContractAttributes { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentAttributes88 ContractAttributes { get; init; } 
    #else
    public FinancialInstrumentAttributes88 ContractAttributes { get; set; } 
    #endif
    
    /// <summary>
    /// Attributes of a derivative that are specific to whether the derivative is a value defined derivative or quantity defined derivative.
    /// </summary>
    [IsoId("_ttQKIOPJEea7_eMQH225xA")]
    [DisplayName("Defined Attributes")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DfndAttrbts")]
    #endif
    [IsoXmlTag("DfndAttrbts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DefinedAttributes1Choice_? DefinedAttributes { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DefinedAttributes1Choice_? DefinedAttributes { get; init; } 
    #else
    public DefinedAttributes1Choice_? DefinedAttributes { get; set; } 
    #endif
    
    
    #nullable disable
    
}
