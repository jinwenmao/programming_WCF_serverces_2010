// 2011 IDesign Inc.
//Questions? Comments? go to 
//http://www.idesign.net

using System;

namespace ServiceModelEx
{
   public class TransactionalMemoryProvider : MemoryProvider
   {
      public TransactionalMemoryProvider(Guid id) : base(id,new TransactionalMemoryStore<Guid,object>())
      {}
   }
}
