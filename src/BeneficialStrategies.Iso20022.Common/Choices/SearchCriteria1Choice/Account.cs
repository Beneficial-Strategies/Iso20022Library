// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SearchCriteria1Choice
{
    /// <summary>
    /// Identifies the account as the search criteria for the financial institution to do the investigation.
    /// </summary>
    [IsoId("_Dhy-5UDHEeGUr-Tp_ntVFg")]
    [DisplayName("Account")]
    public partial record Account : SearchCriteria1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Specifies the account for the investigation.
        /// </summary>
        [IsoId("_3FiS_E1FEeGAs6v-iSb2RQ")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        public required CashAccount25 Identification { get; init; } 
        
        /// <summary>
        /// Specifies the investigated parties related to the account such as the owner, beneficiary, signatory or any party playing a role in that account for which the investigation needs to be done.
        /// </summary>
        [IsoId("_AX1IbE4wEeGFgOSp_IATnQ")]
        [DisplayName("Investigated Parties")]
        [IsoXmlTag("InvstgtdPties")]
        public required InvestigatedParties1Choice_ InvestigatedParties { get; init; } 
        
        /// <summary>
        /// Identifies the authority request type as a code.
        /// </summary>
        [IsoId("_EcwSUUyvEeGcV5yVhSZuNw")]
        [DisplayName("Authority Request Type")]
        [IsoXmlTag("AuthrtyReqTp")]
        public ValueList<AuthorityRequestType1> AuthorityRequestType { get; init; } = new ValueList<AuthorityRequestType1>(){}; // Warning: Don't know multiplicity.
        // ID for the above is _EcwSUUyvEeGcV5yVhSZuNw
        
        
        #nullable disable
        
    }
}
