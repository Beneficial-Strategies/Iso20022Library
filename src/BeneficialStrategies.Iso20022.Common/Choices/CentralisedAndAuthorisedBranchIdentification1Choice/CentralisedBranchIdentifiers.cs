// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
using System.ComponentModel.DataAnnotations;
#endif
namespace BeneficialStrategies.Iso20022.Choices.CentralisedAndAuthorisedBranchIdentification1Choice
{
    /// <summary>
    /// Identifier of the centralised branch.
    /// </summary>
    [IsoId("_VMAeEB9qEeapDZRA0Hb6ow")]
    [DisplayName("Centralised Branch Identifiers")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record CentralisedBranchIdentifiers : CentralisedAndAuthorisedBranchIdentification1Choice_
    #else
    public partial class CentralisedBranchIdentifiers : CentralisedAndAuthorisedBranchIdentification1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Repeated identifiers.
        /// </summary>
        [IsoId("_Bwxs8CD1Eeav65mEytrgaA")]
        [DisplayName("List")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="List")]
        #endif
        [IsoXmlTag("List")]
        public ValueList<FinancialInstitutionIdentification9> List { get; init; } = new ValueList<FinancialInstitutionIdentification9>(){}; // Warning: Don't know multiplicity.
        // ID for the above is _Bwxs8CD1Eeav65mEytrgaA
        
        
        #nullable disable
        
    }
}
