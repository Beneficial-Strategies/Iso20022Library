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
/// Identifies the account as the search criteria for the financial institution to do the investigation.
/// </summary>
[IsoId("_06D5001FEeGAs6v-iSb2RQ")]
[DisplayName("Account And Parties")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountAndParties1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AccountAndParties1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AccountAndParties1( CashAccount25 reqIdentification,InvestigatedParties1Choice_ reqInvestigatedParties )
    {
        Identification = reqIdentification;
        InvestigatedParties = reqInvestigatedParties;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the account for the investigation.
    /// </summary>
    [IsoId("_3FiS_E1FEeGAs6v-iSb2RQ")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CashAccount25 Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CashAccount25 Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount25 Identification { get; init; } 
    #else
    public CashAccount25 Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the investigated parties related to the account such as the owner, beneficiary, signatory or any party playing a role in that account for which the investigation needs to be done.
    /// </summary>
    [IsoId("_AX1IbE4wEeGFgOSp_IATnQ")]
    [DisplayName("Investigated Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstgtdPties")]
    #endif
    [IsoXmlTag("InvstgtdPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InvestigatedParties1Choice_ InvestigatedParties { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InvestigatedParties1Choice_ InvestigatedParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestigatedParties1Choice_ InvestigatedParties { get; init; } 
    #else
    public InvestigatedParties1Choice_ InvestigatedParties { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the authority request type as a code.
    /// </summary>
    [IsoId("_EcwSUUyvEeGcV5yVhSZuNw")]
    [DisplayName("Authority Request Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AuthrtyReqTp")]
    #endif
    [IsoXmlTag("AuthrtyReqTp")]
    public ValueList<AuthorityRequestType1> AuthorityRequestType { get; init; } = new ValueList<AuthorityRequestType1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _EcwSUUyvEeGcV5yVhSZuNw
    
    
    #nullable disable
    
}
