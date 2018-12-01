using System.Collections.Generic;

public class Resources {

    public List<Resource> resourceList;

    public Resources() {
        AddResources();
    }

    void AddResources() {
        resourceList.Add(new Resource("Food", 50, 1));
    }
}
