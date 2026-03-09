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
/// Party and account information.
/// </summary>
[IsoId("_o7MJQEUqEeSGWeX3z5zSZQ")]
[DisplayName("Party Identification And Account")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PartyIdentificationAndAccount119
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the party that legally owns the account.
    /// </summary>
    [IsoId("_Bl2FIEUrEeSGWeX3z5zSZQ")]
    [DisplayName("Party Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtyId")]
    #endif
    [IsoXmlTag("PtyId")]
    public ValueList<PartyIdentification90> PartyIdentification { get; init; } = new ValueList<PartyIdentification90>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _Bl2FIEUrEeSGWeX3z5zSZQ
    
    /// <summary>
    /// Identification of the account owned by the party.
    /// </summary>
    [IsoId("_kNHDAEVKEeSGWeX3z5zSZQ")]
    [DisplayName("Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctId")]
    #endif
    [IsoXmlTag("AcctId")]
    public ValueList<AccountIdentification30> AccountIdentification { get; init; } = new ValueList<AccountIdentification30>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _kNHDAEVKEeSGWeX3z5zSZQ
    
    
    #nullable disable
    
}
