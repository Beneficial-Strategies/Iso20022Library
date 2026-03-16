// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ReportContent1Choice
{
    /// <summary>
    /// Encrypted report content.
    /// </summary>
    [IsoId("_f3ucsMlWEeuJ35KoBRZFOg")]
    [DisplayName("Protected Data")]
    public record ProtectedData : ReportContent1Choice_
    {
        /// <summary>
        /// Type of data protection.
        /// </summary>
        [IsoId("_fj-2MEYdEeegp_DADCe7HQ")]
        [DisplayName("Content Type")]
        [IsoXmlTag("CnttTp")]
        public required ContentType3Code ContentType { get; init; }

        /// <summary>
        /// Consists of an encrypted content of any type and encrypted content-encryption keys for one or more recipients.  The combination of the encrypted content and one encrypted content-encryption key for a recipient is a &quot;digital   envelope&quot; for that recipient.
        /// </summary>
        [IsoId("_sSSU0EYdEeegp_DADCe7HQ")]
        [DisplayName("Enveloped Data")]
        [IsoXmlTag("EnvlpdData")]
        public EnvelopedData6? EnvelopedData { get; init; }

        /// <summary>
        /// Contains encrypted data and the attributes used to encrypt the data using the ISO 13492 methods for data encryption.  The encryption key is not included in the message with this method.
        /// </summary>
        [IsoId("_pF-HID6TEeq_lLaSkIVjTQ")]
        [DisplayName("Encrypted Data")]
        [IsoXmlTag("NcrptdData")]
        public EncryptedData1? EncryptedData { get; init; }
    }
}
