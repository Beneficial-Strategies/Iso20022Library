// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CentralisedAndAuthorisedBranchIdentification1Choice
{
    /// <summary>
    /// Identifier of the centralised branch.
    /// </summary>
    [IsoId("_VMAeEB9qEeapDZRA0Hb6ow")]
    [DisplayName("Centralised Branch Identifiers")]
    public partial record CentralisedBranchIdentifiers : CentralisedAndAuthorisedBranchIdentification1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Repeated identifiers.
        /// </summary>
        [IsoId("_Bwxs8CD1Eeav65mEytrgaA")]
        [DisplayName("List")]
        [IsoXmlTag("List")]
        public ValueList<FinancialInstitutionIdentification9> List { get; init; } = new ValueList<FinancialInstitutionIdentification9>(){}; // Warning: Don't know multiplicity.
        // ID for the above is _Bwxs8CD1Eeav65mEytrgaA
        
        
        #nullable disable
        
    }
}
