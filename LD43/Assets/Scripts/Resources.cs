using System.Collections.Generic;

public class Resources {

    public List<Resource> resourceList;

    public Resources() {
        resourceList = new List<Resource>();
        AddResources();
    }

    void AddResources() {
        resourceList.Add(new Resource("Food", 50, 0));
    }

    public void Update() {
        foreach (Resource resource in resourceList) {
            resource.Update();
        }
    }
}
