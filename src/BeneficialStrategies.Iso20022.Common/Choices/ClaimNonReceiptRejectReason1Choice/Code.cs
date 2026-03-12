// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ClaimNonReceiptRejectReason1Choice
{
    /// <summary>
    /// Reason for the rejection, in a coded form.
    /// </summary>
    [IsoId("_LafiFItuEee-OJ-wXSj3YQ")]
    [DisplayName("Code")]
    public partial record Code : ClaimNonReceiptRejectReason1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason for the rejection of a claim non receipt, as published in an external claim non receipt rejection code set.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalClaimNonReceiptRejection1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
