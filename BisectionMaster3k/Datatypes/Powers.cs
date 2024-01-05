//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

/**
 * Klasa Powers - Cele:
 * # Nie pozwol na dodanie elementu ujemnego
 */

namespace BisectionMaster3k.Datatypes
{
  //-----------------------------------------------------------------------------
  public class Powers<T> : List<T>
  {
    private List<T> values = new List<T>();

    // How Many Elements in private List
    public int Count
    {
      get { return values.Count; }

    }

    //*****************************************************************************
    // Indexer
    public T this[int index]
    {
      get
      {
        if (index < 0 || index >= values.Count)
        {
          throw new IndexOutOfRangeException("Index out of range.");

        }

        return values[index];

      }

      set
      {
        if (index < 0 || index >= values.Count)
        {
          throw new IndexOutOfRangeException("Index out of range.");

        }

        values[index] = value;

      }

    }

    //*****************************************************************************
    // Shadow List<type>.Add()
    public void Add(T element)
    {
      try
      {
        // Powers negative
        if (Convert.ToDouble(element) < 0.0)
        {
          throw new Exception(Exceptions.EPowersNegativeMsg);

        }

      }
      catch (Exception e)
      {
        switch (e.Message)
        {
          // Powers negative
          case Exceptions.EPowersNegative:
            Exceptions.vActPowersNegative();
            break;

        }

      }

      values.Add(element);

    }

  }
}
