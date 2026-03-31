// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ModificationStatusReason1Choice
{
    /// <summary>
    /// Reason for the modification status, in a coded form.
    /// </summary>
    [IsoId("_MG4Hg4lsEeePr-EGJjGYzQ")]
    [DisplayName("Code")]
    public record Code : ModificationStatusReason1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason for the rejection of a modification, as published in an external payment modification rejection code set.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalPaymentModificationRejection1Code Value { get; init; }
    }
}
