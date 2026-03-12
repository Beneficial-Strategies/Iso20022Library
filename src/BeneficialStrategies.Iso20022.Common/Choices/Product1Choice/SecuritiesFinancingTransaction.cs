// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Product1Choice
{
    /// <summary>
    /// Attributes relating to repurchase agreement cleared by the CCP.
    /// </summary>
    [IsoId("_L8Gl0LVQEeadLcJesEbkTQ")]
    [DisplayName("Securities Financing Transaction")]
    public partial record SecuritiesFinancingTransaction : Product1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Specifies attributes of a derivative based on Final ISDA Taxonomy v1.0 and Final ISDA Taxonomy v2.0.
        /// </summary>
        [IsoId("_EBtPIDXHEemdWfjs3tykFQ")]
        [DisplayName("Product Classification")]
        [IsoXmlTag("PdctClssfctn")]
        public required ProductClassification1 ProductClassification { get; init; } 
        
        /// <summary>
        /// Indicates whether the repo is a general collateral repo or specific repo.
        /// </summary>
        [IsoId("_aYveibcREeabfchHYoktpA")]
        [DisplayName("Repurchase Agreement Type")]
        [IsoXmlTag("RpAgrmtTp")]
        public required RepurchaseAgreementType1Choice_ RepurchaseAgreementType { get; init; } 
        
        /// <summary>
        /// Identifier for triparty agent if applicable.
        /// </summary>
        [IsoId("_aYvei7cREeabfchHYoktpA")]
        [DisplayName("Triparty Agent")]
        [IsoXmlTag("TrptyAgt")]
        [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
        public IsoLEIIdentifier? TripartyAgent { get; init; } 
        
        
        #nullable disable
        
    }
}
