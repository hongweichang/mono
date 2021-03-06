// <copyright file="CacheEntryUpdateArguments.cs" company="Microsoft">
//   Copyright (c) 2009 Microsoft Corporation.  All rights reserved.
// </copyright>
using System;

namespace System.Runtime.Caching {
    public class CacheEntryUpdateArguments {
        private String _key;
        private CacheEntryRemovedReason _reason;
        private String _regionName;
        private ObjectCache _source;
        private CacheItem _updatedCacheItem;
        private CacheItemPolicy _updatedCacheItemPolicy;

        public String Key { 
            get { return _key; } 
        }

        public CacheEntryRemovedReason RemovedReason { 
            get { return _reason; } 
        }

        public String RegionName { 
            get { return _regionName; }
        }

        public ObjectCache Source { 
            get { return _source; }
        }

        public CacheItem UpdatedCacheItem { 
            get { return _updatedCacheItem; }
            set { _updatedCacheItem = value; }
        }

        public CacheItemPolicy UpdatedCacheItemPolicy {
            get { return _updatedCacheItemPolicy; }
            set { _updatedCacheItemPolicy = value; }
        }

        public CacheEntryUpdateArguments(ObjectCache source, CacheEntryRemovedReason reason, String key, String regionName) {
            if (source == null) {
                throw new ArgumentNullException("source");
            }
            if (key == null) {
                throw new ArgumentNullException("key");
            }
            _source = source;
            _reason = reason;
            _key = key;
            _regionName = regionName;
        }
    }
}


