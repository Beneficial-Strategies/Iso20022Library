// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Framework
{
    /// <summary>
    /// What a reader or writer needs to know about a message besides its members: its ISO identifier, the
    /// XML element that holds it and the namespace of its document. Carried by every message interface, so a
    /// class that implements the interface (a record, or one made at run time) is read and written without
    /// the record's constants.
    /// </summary>
    [AttributeUsage(AttributeTargets.Interface | AttributeTargets.Class, Inherited = false)]
    public sealed class IsoMessageAttribute : System.Attribute
    {
        /// <summary>The message definition identifier, for example <c>pacs.008.001.14</c>.</summary>
        public string IsoIdentifier { get; }

        /// <summary>The XML element of the message inside the document, for example <c>FIToFICstmrCdtTrf</c>.</summary>
        public string XmlTag { get; }

        /// <summary>The XML namespace of the document, for example <c>urn:iso:std:iso:20022:tech:xsd:pacs.008.001.14</c>.</summary>
        public string DocumentNamespace { get; }

        /// <summary>The name of the document's root element. <c>Document</c> for every ISO message.</summary>
        public string DocumentElementName { get; set; } = "Document";

        /// <summary>Constructs the attribute for one message.</summary>
        public IsoMessageAttribute(string isoIdentifier, string xmlTag, string documentNamespace)
        {
            IsoIdentifier = isoIdentifier;
            XmlTag = xmlTag;
            DocumentNamespace = documentNamespace;
        }

        /// <summary>
        /// Finds the attribute for a message type: on the type itself, else on an interface it implements.
        /// </summary>
        public static IsoMessageAttribute? Find(Type messageType)
        {
            if (messageType.GetCustomAttributes(typeof(IsoMessageAttribute), false).FirstOrDefault() is IsoMessageAttribute own)
                return own;
            foreach (var iface in messageType.GetInterfaces())
                if (iface.GetCustomAttributes(typeof(IsoMessageAttribute), false).FirstOrDefault() is IsoMessageAttribute found)
                    return found;
            return null;
        }
    }
}
